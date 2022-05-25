
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDatabaseImplement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        List<Conf> Confs { get; set; }
    }
}
