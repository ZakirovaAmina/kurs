using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBusinessLogic.ViewModels
{
    public class ReportRoomViewModel
    {
        public decimal Sum { get; set; }
        public Dictionary<string, int> Rooms { get; set; }
    }
}
