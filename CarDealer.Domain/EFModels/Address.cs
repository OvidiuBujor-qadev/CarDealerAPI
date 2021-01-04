using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarDealer.Domain
{
    public class Address: ModelBase
    {
        [Required]
        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
