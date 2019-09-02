using InventorySales.Application.Products.Commands.CreateProduct;
using InventorySales.Application.Products.Queries.GetProductList;
using InventoyAndSalesCleanArchitect.Product.Model;
using InventoyAndSalesCleanArchitect.Product.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoyAndSalesCleanArchitect.Product
{
    [RoutePrefix("Product")]
    public class ProductController : Controller
    {
        private readonly IGetProductListQuery getProductListQuery;
        private readonly ICreateProductViewModelFactory viewModelFactory;
        private readonly ICreateProductCommand createProductCommand;
        public ProductController(IGetProductListQuery getProductListQuery, ICreateProductViewModelFactory viewModelFactory,
                                 ICreateProductCommand createProductCommand)
        {
            this.getProductListQuery = getProductListQuery;
            this.viewModelFactory = viewModelFactory;
            this.createProductCommand = createProductCommand;
        }
        // GET: Product
        public ActionResult Index()
        {
            var products = getProductListQuery.Execute();

            return View(products);
        }

        [Route("create")]
        public ActionResult Create()
        {
            var productViewModel = viewModelFactory.Create();

            return View(productViewModel);
        }

        [Route("create")]
        [HttpPost]
        public ActionResult Create(CreateProductViewModel viewModel)
        {
            createProductCommand.Execute(viewModel.createProductModel);
            
            return View("Index");
        }    
    }
}