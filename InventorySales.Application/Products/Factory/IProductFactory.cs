using InventorySales.Domain.InventoryLevels;
using InventorySales.Domain.Products;
using InventorySales.Domain.ProductsInSales;
using InventorySales.Domain.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Factory
{
    public interface IProductFactory
    {
        Product CreateProduct();

        Product_Types CreateProductTypes();
    }
}
