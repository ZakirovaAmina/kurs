using System;
using System.Collections.Generic;
using System.Text;
using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.Interfaces;
using HotelBusinessLogic.ViewModels;

namespace HotelBusinessLogic.BusinessLogic
{
    public class EmployeeLogic
    {
        private readonly IEmployeeStorage _employeeStorage;
        public EmployeeLogic(IEmployeeStorage employeeStorage)
        {
            _employeeStorage = employeeStorage;
        }
        public List<EmployeeViewModel> Read(EmployeeBindingModel model)
        {
            if (model == null)
            {
                return _employeeStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<EmployeeViewModel> { _employeeStorage.GetElement(model)
};
            }
            return _employeeStorage.GetFilteredList(model);
        }

        public EmployeeViewModel Check(EmployeeBindingModel model)
        {
            return _employeeStorage.GetElement(model);
        }
        public void CreateOrUpdate(EmployeeBindingModel model)
        {
            var element = _employeeStorage.GetElement(new EmployeeBindingModel
            {
                Phone=model.Phone
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть сотрудник с таким телефоном");
            }
            if (model.Id.HasValue)
            {
                _employeeStorage.Update(model);
            }
            else
            {
                _employeeStorage.Insert(model);
            }
        }
        public void Delete(EmployeeBindingModel model)
        {
            var element = _employeeStorage.GetElement(new EmployeeBindingModel
            {
                Id =
           model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _employeeStorage.Delete(model);
        }
    }
}
