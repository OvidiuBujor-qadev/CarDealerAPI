using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Domain
{
    public class Option: ModelBase
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
        public OptCategoryEnum Category { get; set; }
        public string Specification { get; set; }
        public List<InvoiceOption> InvoiceOptions { get; set; }
    }
}
