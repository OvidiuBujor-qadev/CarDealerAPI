using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CarDealer.Domain
{
    public class InvoiceModel: ModelBase
    {
        public AddressModel Address { get; set; }
        public int AddressId {get; set;}
        public CustomerModel Customer { get; set; }
        public int CustomerId { get; set; }
        public CarModel Car { get; set; }
        public int CarId { get; set; }
        public List<InvoiceOptionModel> InvoiceOption { get; set; }
    }
}
