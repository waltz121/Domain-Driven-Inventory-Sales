using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorySales.Domain.InventoryLevels;
using InventorySales.Domain.Products;
using InventorySales.Domain.ProductsInSales;
using InventorySales.Domain.ProductTypes;

namespace InventorySales.Application.Products.Factory
{
    public class ProductFactory : IProductFactory
    {
        public Product CreateProduct()
        {
            var product = new Product();
            
            return product;
        }

        public Product_Types CreateProductTypes()
        {
            var productTypes = new Product_Types();

            return productTypes;
        }
    }
}
