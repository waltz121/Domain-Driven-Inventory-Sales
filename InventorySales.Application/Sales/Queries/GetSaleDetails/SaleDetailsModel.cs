using InventorySales.Application.Products.Queries.GetProductDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Sales.Queries.GetSaleDetails
{
    public class SaleDetailsModel
    {
        public int Id { get; set; }
        public DateTime? DateOfSale { get; set; }
        public double? TotalAmountOfSale { get; set; }
        public List<ProductDetailsModel> Products { get; set; }
        
    }
}
