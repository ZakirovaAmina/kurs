using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBusinessLogic.Interfaces
{
    public interface IConfStorage
    {
        List<ConfViewModel> GetFullList();

        List<ConfViewModel> GetFilteredList(ConfBindingModel model);
        ConfViewModel GetElement(ConfBindingModel model);
        List<ConfViewModel> GetFilteredListEmployee(ConfBindingModel model);
        List<ConfViewModel> GetFilteredListDate(ConfBindingModel model);

        void Insert(ConfBindingModel model);

        void Update(ConfBindingModel model);

        void Delete(ConfBindingModel model);
    }
}

