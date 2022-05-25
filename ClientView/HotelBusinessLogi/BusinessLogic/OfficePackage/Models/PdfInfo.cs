using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBusinessLogic.ViewModels;

namespace HotelBusinessLogic.BusinessLogic.OfficePackage.Models
{
    public class PdfInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public List<ReportConfViewModel> Confs { get; set; }
    }

}
