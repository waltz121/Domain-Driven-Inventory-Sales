using System;
using System.Collections.Generic;

namespace InventorySales.Application.Sales.Commands.CreateSale
{
    public class CreateSaleModel
    {
        public DateTime? DateOfSale { get; set; }
        public double TotalAmountOfSale { get; set; }
        public int Id { get; set; }
        public int Quantity { get; set; }
        public List<ProductInSaleModel> Products { get; set; }
    }
}
