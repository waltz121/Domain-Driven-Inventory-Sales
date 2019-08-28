
using InventorySales.Application.Sales.Queries;
using InventorySales.Application.Sales.Queries.GetSalesList;
using System.Web.Mvc;

namespace InventoyAndSalesCleanArchitect.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetSalesListQuery _salesListQuery;

        public HomeController(IGetSalesListQuery salesListQuery)
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