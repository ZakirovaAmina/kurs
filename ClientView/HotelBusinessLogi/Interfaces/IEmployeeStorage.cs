﻿using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBusinessLogic.Interfaces
{
    public interface IEmployeeStorage
    {
        List<EmployeeViewModel> GetFullList();

        List<EmployeeViewModel> GetFilteredList(EmployeeBindingModel model);

        EmployeeViewModel GetElement(EmployeeBindingModel model);

        void Insert(EmployeeBindingModel model);

        void Update(EmployeeBindingModel model);

        void Delete(EmployeeBindingModel model);
    }
}

