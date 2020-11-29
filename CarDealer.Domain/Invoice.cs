using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CarDealer.Domain
{
    public class Invoice: ModelBase
    {
        public Invoice() 
        {
            Cars = new Collection<Car>();
        }
        public Address Address { get; set; }
        public int AddressId {get; set;}
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Collection<Car> Cars { get; set; }
    }
}
