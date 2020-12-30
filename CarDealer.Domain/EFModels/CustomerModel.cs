using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarDealer.Domain
{
    public class CustomerModel:ModelBase
    {
        public CustomerModel() 
        {
            Addresses = new Collection<AddressModel>();
            Invoices = new Collection<InvoiceModel>();
        }
        [Required]
        public string LastName {get; set;}
        [Required]
        public string FirstName { get; set; }
        public Collection<AddressModel> Addresses { get; set; }
        public Collection<InvoiceModel> Invoices { get; set; }
    }
}
