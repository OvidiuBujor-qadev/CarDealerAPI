using CarDealer.Domain;
using System.Collections.ObjectModel;

namespace CarDealerBusiness.CarDealerDTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public CustomerDTO()
        {
            Addresses = new Collection<Address>();
            Invoices = new Collection<Invoice>();
        }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Collection<Address> Addresses { get; set; }
        public Collection<Invoice> Invoices { get; set; }
    }
}
