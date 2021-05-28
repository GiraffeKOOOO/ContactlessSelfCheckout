using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactlessSelfCheckout
{
    /// <summary>
    /// This is the Product class, which allows for the creation of products, and to use them throughout the program
    /// </summary>
    public class Product
    {
        public int productID;
        public string productName;
        public string productCategory;
        public decimal productPrice;
        public int productStock;
        public Product(int productID, string productName, string productCategory, decimal productPrice, int productStock)
        {
            this.productID = productID;
            this.productName = productName;
            this.productCategory = productCategory;
            this.productPrice = productPrice;
            this.productStock = productStock;
        }
    }
}
