using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
namespace HotelBusinessLogic.Interfaces
{
    public interface IPaymentStorage
    {
        List<PaymentViewModel> GetFullList();

        List<PaymentViewModel> GetFilteredList(PaymentBindingModel model);

        PaymentViewModel GetElement(PaymentBindingModel model);

        void Insert(PaymentBindingModel model);

        void Update(PaymentBindingModel model);

        PaymentViewModel GetElementFirstLast(PaymentDateBindingModel model);
        void Delete(PaymentBindingModel model);
    }
}


