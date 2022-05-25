using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.Interfaces;
using HotelBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelBusinessLogic.BusinessLogics
{
    public class ConfLogic 
    {
        private readonly IConfStorage _ConfsStorage;
        private readonly IRoomStorage roomStorage;

        public ConfLogic(IConfStorage ConfsStorage, IRoomStorage roomStorage)
        {
            this.roomStorage = roomStorage;
            _ConfsStorage = ConfsStorage;
        }

        public List<ConfViewModel> Read(ConfBindingModel model)
        {
            if (model == null)
            {
                return _ConfsStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ConfViewModel> { _ConfsStorage.GetElement(model) };
            }
            return _ConfsStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(ConfBindingModel model)
        {
            
            if (model.Id.HasValue)
            {
                _ConfsStorage.Update(model);
            }
            else
            {
                _ConfsStorage.Insert(model);
            }

        }

        public void Delete(ConfBindingModel model)
        {
            var element = _ConfsStorage.GetElement(new ConfBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Услуга не найдена");
            }
            _ConfsStorage.Delete(model);
        }
        public List<ConfViewModel> ReadEmployee(ConfBindingModel model)
        {
            return _ConfsStorage.GetFilteredListEmployee(model);
        }
    }
}
