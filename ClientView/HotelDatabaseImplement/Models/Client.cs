using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HotelBusinessLogic.Enums;
using HotelDatabaseImplement.Models;

namespace HotelDatabaseImplement.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public List<Conf> Confs { get; set; }
    }
}

