using System;
using System.Collections.Generic;
using System.Text;
using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.Interfaces;
using HotelBusinessLogic.ViewModels;

namespace HotelBusinessLogic.BusinessLogic
{
    public class PaymentLogic
    {
        private readonly IPaymentStorage _PaymentsStorage;

        public PaymentLogic(IPaymentStorage PaymentsStorage)
        {
            _PaymentsStorage = PaymentsStorage;
        }

        public List<PaymentViewModel> Read(PaymentBindingModel model)
        {
            if (model == null)
            {
                return _PaymentsStorage.GetFullList();
            }
            if (model.Id!=0)
            {
                return new List<PaymentViewModel> { _PaymentsStorage.GetElement(model) };
            }
            return _PaymentsStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(PaymentBindingModel model)
        {
            if (model.Id!=0)
            {
                _PaymentsStorage.Update(model);
            }
            else
            {
                _PaymentsStorage.Insert(model);
            }

        }

        public void Delete(PaymentBindingModel model)
        {
            var element = _PaymentsStorage.GetElement(new PaymentBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Услуга не найдена");
            }
            _PaymentsStorage.Delete(model);
        }
    }
}
