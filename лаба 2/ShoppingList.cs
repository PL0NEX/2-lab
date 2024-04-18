using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2
{
    public class ShopingList : List<Product>
    {
        public decimal TotalPrice()
        {
            return this.Sum(Product => Product.TotalPrice());
        }
    }
}
