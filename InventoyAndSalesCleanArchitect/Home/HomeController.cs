using InventorySales.Application.Sales.Queries.GetSalesList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoyAndSalesCleanArchitect.Home
{
    public class HomeController : Controller
    {
        private readonly IGetSalesListQuery _salesListQuery;

        public HomeController(IGetSalesListQuery salesListQuery)
        {
            _salesListQuery = salesListQuery;
        }
        // GET: Home
        public ActionResult Index()
        {
            var sales = _salesListQuery.Execute();

            return View(sales);
        }
    }
}