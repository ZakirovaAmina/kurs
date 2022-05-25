using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.BusinessLogic.OfficePackage;
using HotelBusinessLogic.BusinessLogic.OfficePackage.Models;
using HotelBusinessLogic.Interfaces;
using HotelBusinessLogic.ViewModels;

namespace HotelBusinessLogic.BusinessLogic
{
    public class ReportLogic
    {
        private readonly IRoomStorage _roomStorage;
        private readonly IConfStorage _ConfStorage;
        private readonly ReportToExcel _saveToExcel;
        private readonly ReportToWord _saveToWord;
        private readonly ReportToPdf _saveToPdf;
        private readonly IPaymentStorage paymentStorage;
        public ReportLogic(IConfStorage ConfStorage, IPaymentStorage paymentStorage, IRoomStorage roomStorage,
        ReportToExcel saveToExcel, ReportToWord saveToWord, ReportToPdf saveToPdf)
        {
            this.paymentStorage = paymentStorage;
            _ConfStorage = ConfStorage;
            _roomStorage = roomStorage;
            _saveToExcel = saveToExcel;
            _saveToWord = saveToWord;
            _saveToPdf = saveToPdf;
        }
        public List<ReportConfRoomViewModel> GetConfRoom(int UserId)
        {
            var Confs = _ConfStorage.GetFilteredList(new ConfBindingModel()
            {
                ClientId=UserId
            });
            var list = new List<ReportConfRoomViewModel>();
            foreach (var Conf in Confs)
            {
                var record = new ReportConfRoomViewModel
                {
                    ConfDate = Conf.ConfsDate,
                    Rooms = new List<string>(),
                    TotalCount = 0
                };
                foreach (var room in Conf.ConfRooms)
                {
                    record.Rooms.Add(room.Value);
                    record.TotalCount+=1;
                }
                list.Add(record);
            }
            return list;
        }
        public List<ReportRoomConfViewModel> GetRoomConf(int UserId)
        {
            var rooms = _roomStorage.GetFullList();
            var list = new List<ReportRoomConfViewModel>();
            foreach (var room in rooms)
            {
                var record = new ReportRoomConfViewModel
                {
                    Name= room.Name,
                    Confs= new List<DateTime>(),
                    TotalCount = 0
                };
                foreach (var conf in room.ConfRooms)
                {
                    record.Confs.Add(conf.Value.Item2);
                    record.TotalCount += 1;
                }
                list.Add(record);
            }
            return list;
        }
        public void SaveConfRoomToExcelFile(ReportBindingModel model)
        {
            _saveToExcel.CreateReportConfRoom(new ExcelInfoConfRoom
            {
                FileName = model.FileName,
                Title = "Список конференций",
                ConfRooms = GetConfRoom(model.UserId)
            });
        }
        public void SaveRoomConfToExcelFile(ReportBindingModel model)
        {
            _saveToExcel.CreateReportRoomConf(new ExcelInfoRoomConf
            {
                FileName = model.FileName,
                Title = "Список номеров",
                ConfRooms = GetRoomConf(model.UserId)
            });
        }
        public void SaveConfRoomToWordFile(ReportBindingModel model)
        {
            _saveToWord.CreateDocConfRoom(new WordInfoConfRoom
            {
                FileName = model.FileName,
                Title = "Конференции по номерам",
                ConfRooms = GetConfRoom(model.UserId)
            });
        }
        public void SaveRoomConfToWordFile(ReportBindingModel model)
        {
            _saveToWord.CreateDocRoomConf(new WordInfoRoomConf
            {
                FileName = model.FileName,
                Title = "Номера по конференциям",
                ConfRooms = GetRoomConf(model.UserId)
            });
        }
        public List<ReportConfViewModel> GetOrders(ReportBindingModel model)
        {
            return _ConfStorage.GetFilteredListDate(new ConfBindingModel
            {
                DateFrom =
           model.DateFrom,
                DateTo = model.DateTo
            })
            .Select(x => new ReportConfViewModel
            {
                DateCreate = x.ConfsDate,
                ClientName = x.ClientName,
                Sum=x.Sum
            })
           .ToList();
        }
        public ReportRoomViewModel GetRooms(ReportBindingModel model)
        {
            var list = _ConfStorage.GetFilteredListDate(new ConfBindingModel
            {
                DateFrom =
           model.DateFrom,
                DateTo = model.DateTo
            });
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach(var item in list)
            {
                foreach(var item2 in item.ConfRooms)
                {
                    if (dic.ContainsKey(item2.Value))
                    {
                        dic[item2.Value]++;
                    }
                    else
                    {
                        dic[item2.Value] = 1;
                    }
                }
                
            }
            return new ReportRoomViewModel()
            {
                Sum = paymentStorage.GetElementFirstLast(new PaymentDateBindingModel()).Remains,
                Rooms = dic
            };
        }
        public void SaveOrdersToPdfFileConf(ReportBindingModel model)
        {
            _saveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список конференций",
                DateFrom = model.DateFrom.Value,
                DateTo = model.DateTo.Value,
                Confs = GetOrders(model)
            });
        }
        public void SaveOrdersToPdfFileRoom(ReportBindingModel model)
        {
            _saveToPdf.CreateDocRoom(new PdfInfoRoom
            {
                FileName = model.FileName,
                Title = "Список номеров",
                DateFrom = model.DateFrom.Value,
                DateTo = model.DateTo.Value,
                Rooms = GetRooms(model)
            });
        }
    }
}
