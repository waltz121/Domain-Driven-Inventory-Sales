using InventorySales.Application.Products.Queries.GetProductList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoyAndSalesCleanArchitect.Product
{
    public class ProductController : Controller
    {
        private readonly IGetProductListQuery getProductListQuery;
        public ProductController(IGetProductListQuery getProductListQuery)
        {
            this.getProductListQuery = getProductListQuery;
        }
        // GET: Product
        public ActionResult Index()
        {
            var products = getProductListQuery.Execute();

            return View(products);
        }
    }
}