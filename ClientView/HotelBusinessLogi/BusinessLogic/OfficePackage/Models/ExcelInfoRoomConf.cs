using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBusinessLogic.ViewModels;

namespace HotelBusinessLogic.BusinessLogic.OfficePackage.Models
{
    public class ExcelInfoRoomConf
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportRoomConfViewModel> ConfRooms { get; set; }
    }
}
