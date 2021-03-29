using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactlessSelfCheckout
{
    public class Product
    {
        public int productId;
        public string productName;
        public string productCategory;
        public decimal productPrice;
        public int productStock;
        public Product(int productId, string productName, string productCategory, decimal productPrice, int productStock)
        {
            this.productId = productId;
            this.productName = productName;
            this.productCategory = productCategory;
            this.productPrice = productPrice;
            this.productStock = productStock;
        }
    }
}
