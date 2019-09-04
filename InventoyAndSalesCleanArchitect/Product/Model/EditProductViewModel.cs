using InventorySales.Application.Products.Commands.UpdateProduct;
using InventorySales.Application.Products.Queries.GetProductDetails;
using System.Collections.Generic;
using System.Web.Mvc;

namespace InventoyAndSalesCleanArchitect.Product.Model
{
    public class EditProductViewModel
    {
        public List<SelectListItem> productTypesList { get; set; }
        public UpdateProductModel UpdateProductModel { get; set; }
        public ProductDetailsModel ProductDetailsModel { get; set; }
    }
}