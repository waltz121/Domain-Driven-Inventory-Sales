using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Sales.Queries.GetSalesList
{
    public class SalesListItemModel
    {
        public int Sales_ID { get; set; }
        public DateTime? DateOfSale { get; set; }
        public double? TotalAmountOfSale { get; set; }
    }
}
