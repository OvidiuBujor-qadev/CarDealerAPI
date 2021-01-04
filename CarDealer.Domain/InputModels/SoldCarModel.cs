using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Domain.InputModels
{
    public class SoldCarModel
    {
        public Car Car { get; set; }
        public List<Option> Options { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
    }
}
