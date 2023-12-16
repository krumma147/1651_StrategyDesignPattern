using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeClassLibrary.Products
{
    public enum ProductStatus
    {
        Good,
        OutOfDate
    }

    public class Product
    {
        public ProductStatus Status { get; set; }

        // Other base properties such as price, datetime ....
        // Base Constructor
        public Product()
        {
            // Some initialize here
            Status = ProductStatus.Good;
        }

        public virtual void Use() // This function should be defined in IProductUsage interface and its implement class
        {
            // base login here
        }
    }
}