using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mcdonald.Order.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public decimal OrdAmount { get; set; }
        
        public int ServiceTax { get; set; }      

    }
}
