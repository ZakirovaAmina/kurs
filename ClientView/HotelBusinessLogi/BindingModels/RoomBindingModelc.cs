using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;


namespace HotelBusinessLogic.BindingModels 
{
    public class RoomBindingModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
}
