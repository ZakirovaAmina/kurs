using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelDatabaseImplement.Models
{
    public class Conf
    {
        public int Id { get; set; }
        public DateTime DateConf { get; set; }
        public decimal Sum { get; set; }
        public int? EmployeeId { get; set; }
        public int RoomId { get; set; }
        public int ClientId { get; set; }
        public Employee Employee { get; set; }
        public List<ConfRoom> ConfRooms { get; set; }
        public Client Client { get; set; }
        public virtual List<Payment> Payment { get; set; }
    }
}

