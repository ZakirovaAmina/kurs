using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelDatabaseImplement.Models 
{
    public class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Sum { get; set; }
        public List<RoomExpense> RoomExpenses{ get; set; }

        
    }
}

