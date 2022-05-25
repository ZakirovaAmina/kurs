using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelDatabaseImplement.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public int ConfsId { get; set; }
        public decimal Sum { get; set; }
        public decimal Remains { get; set; }
        public DateTime DateOfPayment { get; set; }
        public Conf Conf { get; set; }

    }
}

