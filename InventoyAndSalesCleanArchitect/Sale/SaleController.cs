using InventorySales.Application.Products.Queries.FindProductLists;
using InventorySales.Application.Products.Queries.GetProductList;
using InventorySales.Application.Sales.Commands.CreateSale;
using InventorySales.Application.Sales.Queries.GetSalesList;
using InventoyAndSalesCleanArchitect.Sale.Model;
using InventoyAndSalesCleanArchitect.Sale.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace InventoyAndSalesCleanArchitect.Sale
{
    public class SaleController : Controller
    {
        private readonly IGetSalesListQuery salesListQuery;
        private readonly ICreateSaleViewModelFactory createSaleViewModelFactory;
        private readonly ICreateSaleCommand createSaleCommand;
        private readonly IFindProductListQuery findProductListQuery;
        public SaleController(IGetSalesListQuery salesListQuery, ICreateSaleViewModelFactory createSaleViewModelFactory,
                              ICreateSaleCommand createSaleCommand, IFindProductListQuery findProductListQuery)
        {
            this.salesListQuery = salesListQuery;
            this.createSaleViewModelFactory = createSaleViewModelFactory;
            this.createSaleCommand = createSaleCommand;
            this.findProductListQuery = findProductListQuery;
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

        [Route("Add")]
        public ActionResult Add(int quantity, int productId, string productDescription)
        {
            List<ProductListItemModel> productLists = new List<ProductListItemModel>();
            ProductListItemModel listItemModel = new ProductListItemModel();

            listItemModel = findProductListQuery.Execute(productId).SingleOrDefault();

            productLists.Add(listItemModel);
            Session["AddedListOfProducts"] = productLists;


            return Json(productLists, JsonRequestBehavior.AllowGet);
        }

    }
}