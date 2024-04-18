using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2
{
    public class Bread:Product
    {
        public string Type { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerLoaf { get; set; }

        public override decimal TotalPrice()
        {
            return PricePerLoaf * Quantity;
        }
    }
}
