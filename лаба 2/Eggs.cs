using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2
{
    public class Eggs:Product
    {
        public string Category {  get; set; }
        public int Quantity { get; set; }
        public decimal PricePerDozen { get; set; }

        public override decimal TotalPrice()
        {
            return PricePerDozen * Quantity;
        }
    }
}
