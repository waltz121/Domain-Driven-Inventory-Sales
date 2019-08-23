using InventorySales.Domain.Common;
using InventorySales.Domain.Products;
using InventorySales.Domain.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Domain.ProductsInSales
{
    public class Products_in_Sales: IEntity
    {
        public int Sales_ID { get; set; }
        public int Product_ID { get; set; }
        public int Quantity { get; set; }
        public int Id { get; set; }
    }
}
