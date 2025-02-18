using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_selling_site.Entities
{
    internal class Food_products
    {
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public DateTime ExpDate { get; set; }
        public int ProductWeight { get; set; }
        public long ProductPrice { get; set; }
        public int ProductNumber { get; set; }
    }
}
