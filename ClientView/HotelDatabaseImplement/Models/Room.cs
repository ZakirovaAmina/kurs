using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelDatabaseImplement.Models
{
    public class Room
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public decimal Cost { get; set; }
        public List<ConfRoom> ConfRooms { get; set; }
    }
}

