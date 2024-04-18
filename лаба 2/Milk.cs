using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2
{
    public class Milk:Product
    {
        public double FatContent { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerPacket { get; set; }

        public override decimal TotalPrice()
        {
            return Quantity * PricePerPacket;
        }
    }
}
