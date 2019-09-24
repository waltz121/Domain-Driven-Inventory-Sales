using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorySales.Domain.ProductsInSales;
using InventorySales.Domain.Sales;

namespace InventorySales.Application.Sales.Factory
{
    public class SaleFactory : ISaleFactory
    {
        public List<Products_in_Sales> CreateListProductsInSales()
        {
            var ListProductsInSales = new List<Products_in_Sales>();

            return ListProductsInSales;
        }

        public Products_in_Sales CreateProductsInSales()
        {
            var productsInSales = new Products_in_Sales();

            return productsInSales;
        }

        public Sale CreateSale()
        {
            var Sale = new Sale();

            return Sale;
        }
    }
}
