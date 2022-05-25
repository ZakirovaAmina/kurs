using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.Interfaces;
using HotelBusinessLogic.ViewModels;
using HotelDatabaseImplement.Models;

namespace HotelDatabaseImplement.Implements
{
    public class PaymentStorage : IPaymentStorage
    {
        public List<PaymentViewModel> GetFullList()
        {
            var context = new HotelDatabase();
            return context.Payments.Include(rec => rec.Conf)
            .Select(CreateViewModel)
            .OrderBy(x=>x.DateOfPayment)
           .ToList();
        }

        public List<PaymentViewModel> GetFilteredList(PaymentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            var context = new HotelDatabase();
            var list = context.Payments.Where(rec => rec.ConfsId == model.ConfId)
            .OrderBy(x => x.DateOfPayment)
            .Include(rec => rec.Conf);
            return list
            .Select(rec => new PaymentViewModel
            {
                DateOfPayment = rec.DateOfPayment,
                Id = rec.Id,
                Remains= rec.Remains,
                Sum = rec.Sum,
                ConfId=rec.ConfsId

            })
             .ToList();
        }    
        

        public PaymentViewModel GetElement(PaymentBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            var context = new HotelDatabase();
            {
                var payment = context.Payments.Include(rec => rec.Conf)
                  .FirstOrDefault(rec => rec.ConfsId == model.ConfId);
                return payment != null ?
                new PaymentViewModel
                {
                    DateOfPayment = payment.DateOfPayment,
                    Id = payment.Id,
                    Remains = payment.Conf.Sum,
                    Sum = payment.Sum,
                    ConfId = payment.ConfsId
                } :
                null;
            }
        }
        public PaymentViewModel GetElementFirstLast(PaymentDateBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            var context = new HotelDatabase();
            {
                return new PaymentViewModel()
                {
                    Remains = context.Payments.Include(rec => rec.Conf)
                    .Where(x => x.DateOfPayment > model.DateFrom || x.DateOfPayment < model.DateTo).Sum(x => x.Sum)
                };
                    
            }
        }

        public void Insert(PaymentBindingModel model)
        {
            var context = new HotelDatabase();
            context.Payments.Add(CreateModel(model, new Payment()));
            context.SaveChanges();
        }

        public void Update(PaymentBindingModel model)
        {
            var context = new HotelDatabase();
            var element = context.Payments.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Оплата не найдена");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }


        public void Delete(PaymentBindingModel model)
        {
            var context = new HotelDatabase();

            Payment element = context.Payments.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Payments.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Оплата не найдена");
            }
        }

        private PaymentViewModel CreateViewModel(Payment payment)
        {
            return new PaymentViewModel
            {
                DateOfPayment = payment.DateOfPayment,
                Id = payment.Id,
                Remains = payment.Conf.Sum,
                Sum = payment.Sum,
                ConfId = payment.ConfsId
            };
        }

        private Payment CreateModel(PaymentBindingModel model, Payment payment)
        {
            payment.DateOfPayment = model.DateOfPayment;
            payment.Id = model.Id;
            payment.Remains = model.Remains;
            payment.Sum = model.Sum;
            payment.ConfsId = model.ConfId;
            return payment;
        }
    }
}

