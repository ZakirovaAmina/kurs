using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBusinessLogic.ViewModels
{
    public class ReportConfRoomViewModel
    {
        public DateTime? ConfDate { get; set; }
        public List<string> Rooms { get; set; }
        public int TotalCount { get; set; }
    }
}
