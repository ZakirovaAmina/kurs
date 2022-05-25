using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDatabaseImplement.Models
{
    public class ConfRoom
    {
        public int Id { get; set; }
        public int ConfId { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public Conf Conf { get; set; }
    }
}
