using System;
using System.Runtime.Serialization;


namespace HotelBusinessLogic.BindingModels
{
    public class PaymentBindingModel
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public decimal Remains { get; set; }
        public DateTime DateOfPayment { get; set; }
        public int ConfId { get; set; }
    }
}

