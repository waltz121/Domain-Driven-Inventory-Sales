using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Sales.Commands.CreateSale
{
    public class ProductInSaleModel
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
