using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace HotelBusinessLogic.ViewModels
{
    public class ConfViewModel
    {
        public int Id { get; set; }
        public DateTime ConfsDate { get; set; }
        public decimal Sum { get; set; }
        public int? EmployeeId { get; set; }
        public int ClientId { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string ClientName { get; set; }
        public string EmployeeName { get; set; }
        public Dictionary<int, string> ConfRooms { get; set; }
    }
}

