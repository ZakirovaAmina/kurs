using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HotelBusinessLogic.BindingModels
{
    public class ConfBindingModel
    {
        public int? Id { get; set; }
        public DateTime ConfsDate { get; set; }
        public decimal Sum { get; set; }
        public int? EmployeeId { get; set; }
        public int ClientId { get; set; }
        public int RoomId { get; set; }
        public Dictionary<int, string> ConfRooms { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}

