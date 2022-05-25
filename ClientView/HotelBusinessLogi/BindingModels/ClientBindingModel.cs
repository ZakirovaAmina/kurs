﻿using HotelBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HotelBusinessLogic.BindingModels
{
    public class ClientBindingModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}


