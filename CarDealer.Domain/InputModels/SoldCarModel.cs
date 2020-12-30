using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Domain.InputModels
{
    public class SoldCarModel
    {
        public CarModel Car { get; set; }
        public List<OptionModel> Options { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
    }
}
