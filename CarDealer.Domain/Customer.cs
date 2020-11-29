using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CarDealer.Domain
{
    public class Customer:ModelBase
    {
        public Customer() 
        {
            Addresses = new Collection<Address>();
            Invoices = new Collection<Invoice>();
        }
        public string LastName {get; set;}
        public string FirstName { get; set; }
        public Collection<Address> Addresses { get; set; }
        public Collection<Invoice> Invoices { get; set; }
    }
}
