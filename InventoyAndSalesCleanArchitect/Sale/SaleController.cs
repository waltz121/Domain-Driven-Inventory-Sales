using InventorySales.Application.Sales.Commands.CreateSale;
using InventorySales.Application.Sales.Queries.GetSalesList;
using InventoyAndSalesCleanArchitect.Sale.Model;
using InventoyAndSalesCleanArchitect.Sale.Services;
using System.Web.Mvc;

namespace InventoyAndSalesCleanArchitect.Sale
{
    public class SaleController : Controller
    {
        private readonly IGetSalesListQuery salesListQuery;
        private readonly ICreateSaleViewModelFactory createSaleViewModelFactory;
        private readonly ICreateSaleCommand createSaleCommand;
        public SaleController(IGetSalesListQuery salesListQuery, ICreateSaleViewModelFactory createSaleViewModelFactory,
                              ICreateSaleCommand createSaleCommand)
        {
            this.salesListQuery = salesListQuery;
            this.createSaleViewModelFactory = createSaleViewModelFactory;
            this.createSaleCommand = createSaleCommand;
        }
        // GET: Sale
        public ActionResult Index()
        {
            var sales = salesListQuery.Execute();

            return View(sales);
        }

        [Route("Create")]
        public ActionResult Create()
        {
            var CreateSalesViewModel = createSaleViewModelFactory.createSaleViewModel();

            return View(CreateSalesViewModel);
        }

        [Route("Create")]
        [HttpPost]
        public ActionResult Create(CreateSaleViewModel createSaleViewModel)
        {

            return RedirectToAction("Index");
        }

    }
}