using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Sales.Queries
{
    public class SalesModel
    {
        public int Sales_ID { get; set; }
        public DateTime? DateOfSale { get; set; }
        public double? TotalAmountOfSale { get; set; }
    }
}
