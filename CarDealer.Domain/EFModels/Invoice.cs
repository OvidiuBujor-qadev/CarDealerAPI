using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CarDealer.Domain
{
    public class Invoice: ModelBase
    {
        public Address Address { get; set; }
        public int AddressId {get; set;}
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
        public List<InvoiceOption> InvoiceOption { get; set; }
    }
}
