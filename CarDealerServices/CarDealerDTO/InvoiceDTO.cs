using CarDealer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealerBusiness.CarDealerDTO
{
    public class InvoiceDTO
    {
        public int Id { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
        public List<InvoiceOption> InvoiceOption { get; set; }
    }
}
