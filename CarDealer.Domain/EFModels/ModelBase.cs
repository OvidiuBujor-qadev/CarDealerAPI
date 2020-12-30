using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Domain
{
    public abstract class ModelBase
    {
        public int Id { get; set; }
        public bool IsDeleted {get; set;}
    }
}
