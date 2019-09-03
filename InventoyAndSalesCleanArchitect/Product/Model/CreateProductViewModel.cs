using InventorySales.Application.Products.Commands.CreateProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoyAndSalesCleanArchitect.Product.Model
{
    public class CreateProductViewModel
    {
        public List<SelectListItem> productTypesList { get; set; }
        public CreateProductModel createProductModel { get; set; }
         
    }
}