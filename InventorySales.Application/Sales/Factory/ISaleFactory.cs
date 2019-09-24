using InventorySales.Domain.ProductsInSales;
using InventorySales.Domain.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Sales.Factory
{
    public interface ISaleFactory
    {
        Sale CreateSale();
        Products_in_Sales CreateProductsInSales();
        List<Products_in_Sales> CreateListProductsInSales();
    }
}
