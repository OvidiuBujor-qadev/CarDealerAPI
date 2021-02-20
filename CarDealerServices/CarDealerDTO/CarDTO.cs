﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerBusiness.CarDealerDTO
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Park { get; set; }
        public int HorsePower { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Km { get; set; }
        public int EngineSize { get; set; }
        public string Fuel { get; set; }
        public string CarType { get; set; }
        public string Condition { get; set; }
        public int Doors { get; set; }
        public bool Sold { get; set; }
    }
}
