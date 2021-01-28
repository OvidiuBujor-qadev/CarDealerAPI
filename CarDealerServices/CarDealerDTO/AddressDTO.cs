using CarDealer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerBusiness.CarDealerDTO
{
    public class AddressDTO
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
