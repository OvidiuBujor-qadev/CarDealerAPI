using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Domain
{
    public class InvoiceOptionModel : ModelBase
    {
        public int InvoiceId { get; set; }
        public InvoiceModel Invoice { get; set; }
        public int OptionId { get; set; }
        public OptionModel Option { get; set; }
    }
}
