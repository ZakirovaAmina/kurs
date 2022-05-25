using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBusinessLogic.ViewModels
{
    public class ReportRoomConfViewModel
    {
        public string Name { get; set; }
        public List<DateTime> Confs { get; set; }
        public int TotalCount { get; set; }
    }
}
