using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Domain
{
    public class OptionModel: ModelBase
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
        public OptCategoryModel Category { get; set; }
        public string Specification { get; set; }
        public List<InvoiceOptionModel> InvoiceOptions { get; set; }
    }
}
