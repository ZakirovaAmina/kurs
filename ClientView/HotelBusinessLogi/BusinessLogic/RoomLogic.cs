using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.Interfaces;
using HotelBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace HotelBusinessLogic.BusinessLogics
{
    public class RoomLogic
    {
        private readonly IRoomStorage _RoomsStorage;

        public RoomLogic(IRoomStorage RoomsStorage)
        {
            _RoomsStorage = RoomsStorage;
        }

        public List<RoomViewModel> Read(RoomBindingModel model)
        {
            if (model == null)
            {
                return _RoomsStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<RoomViewModel> { _RoomsStorage.GetElement(model) };
            }
            return _RoomsStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(RoomBindingModel model)
        {
            if (model.Id.HasValue)
            {
                _RoomsStorage.Update(model);
            }
            else
            {
                _RoomsStorage.Insert(model);
            }
           
        }

        public void Delete(RoomBindingModel model)
        {
            var element = _RoomsStorage.GetElement(new RoomBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Услуга не найдена");
            }
            _RoomsStorage.Delete(model);
        }
    }
}
