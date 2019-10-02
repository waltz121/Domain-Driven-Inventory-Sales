using InventorySales.Application.Products.Queries.GetProductList;
using InventorySales.Application.Sales.Commands.CreateSale;
using System.Collections.Generic;
using System.Web.Mvc;

namespace InventoyAndSalesCleanArchitect.Sale.Model
{
    public class CreateSaleViewModel
    {
        public CreateSaleModel createSaleModel { get; set; }
        public List<SelectListItem> Products { get; set; }
        public List<ProductListItemModel> AddedProducts { get; set; }
        public int SelectedProductValue { get; set; }
    }
}