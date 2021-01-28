using CarDealer.Domain;
using System.Collections.Generic;

namespace CarDealerBusiness.CarDealerDTO
{
    public class OptionDTO
    {
        public int OptionId { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public OptCategoryEnum Category { get; set; }
        public string Specification { get; set; }
        public List<InvoiceOption> InvoiceOptions { get; set; }
    }
}
