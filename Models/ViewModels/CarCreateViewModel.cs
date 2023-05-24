﻿using RentCarsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace RentCarsApp.Models.ViewModels
{
    public class CarCreateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ushort ProductionYear { get; set; }
        public int Price { get; set; }
        public IFormFile Image { get; set; }
        public TransmissionType Transmission { get; set; }
        public FuelType Fuel { get; set; }
    }
}