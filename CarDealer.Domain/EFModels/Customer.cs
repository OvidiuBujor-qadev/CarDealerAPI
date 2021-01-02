using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public string LastName {get; set;}
        [Required]
        public string FirstName { get; set; }
        public Collection<Address> Addresses { get; set; }
        public Collection<Invoice> Invoices { get; set; }
    }
}
