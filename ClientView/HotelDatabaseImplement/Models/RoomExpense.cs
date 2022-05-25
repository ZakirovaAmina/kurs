using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDatabaseImplement.Models
{
    public class RoomExpense
    {
        public int Id { get; set; }
        public int ExpenseId { get; set; }
        public int RoomId { get; set; }
        public Expense Expense { get; set; }
        public Room  Room{ get; set; }
    }
}
