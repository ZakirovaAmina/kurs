﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBusinessLogic.BusinessLogic.OfficePackage.Models
{
    public class ExcelMergeParameters
    {
        public string CellFromName { get; set; }
        public string CellToName { get; set; }
        public string Merge => $"{CellFromName}:{CellToName}";
    }
}
