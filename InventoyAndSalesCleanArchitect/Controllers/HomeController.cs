﻿
using InventorySales.Application.Sales.Queries;
using System.Web.Mvc;

namespace InventoyAndSalesCleanArchitect.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetSalesQuery _salesListQuery;

        public HomeController(IGetSalesQuery salesListQuery)
        {
            _salesListQuery = salesListQuery;
        }
        public ActionResult Index()
        {
            var sales = _salesListQuery.Execute();
            
            return View(sales);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}