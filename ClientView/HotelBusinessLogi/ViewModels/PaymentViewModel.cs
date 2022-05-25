using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace HotelBusinessLogic.ViewModels
{
    public class PaymentViewModel
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public decimal Remains { get; set; }
        public DateTime? DateOfPayment { get; set; }
        public int ConfId { get; set; }
    }
}

