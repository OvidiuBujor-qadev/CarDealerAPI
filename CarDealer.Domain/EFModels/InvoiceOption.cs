using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Domain
{
    public class InvoiceOption : ModelBase
    {
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }
    }
}
