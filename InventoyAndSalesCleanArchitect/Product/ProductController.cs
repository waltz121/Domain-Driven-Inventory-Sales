using InventorySales.Application.Products.Commands.CreateProduct;
using InventorySales.Application.Products.Commands.DeleteProduct;
using InventorySales.Application.Products.Commands.UpdateProduct;
using InventorySales.Application.Products.Queries.GetProductDetails;
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
        private readonly IDeleteProductCommand deleteProductCommand;
        private readonly IEditProductViewModelFactory editProductViewModelFactory;
        private readonly IUpdateProductCommand updateProductCommand;

        public ProductController(IGetProductListQuery getProductListQuery, ICreateProductViewModelFactory viewModelFactory,
                                 ICreateProductCommand createProductCommand, IDeleteProductCommand deleteProductCommand,
                                 IEditProductViewModelFactory editProductViewModelFactory, IUpdateProductCommand updateProductCommand)
        {
            this.getProductListQuery = getProductListQuery;
            this.viewModelFactory = viewModelFactory;
            this.createProductCommand = createProductCommand;
            this.deleteProductCommand = deleteProductCommand;
            this.editProductViewModelFactory = editProductViewModelFactory;
            this.updateProductCommand = updateProductCommand;
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
            
            return RedirectToAction("Index");
        }

        [Route("delete")]
        public ActionResult Delete(int id)
        {
            deleteProductCommand.Execute(id);

            return RedirectToAction("Index");
        }

        [Route("Edit")]
        public ActionResult Edit(int id)
        {
            var productViewModel = editProductViewModelFactory.Create(id);

            return View(productViewModel);
        }

        [Route("Edit")]
        [HttpPost]
        public ActionResult Edit(UpdateProductModel updateProductModel)
        {
            updateProductCommand.Execute(updateProductModel);

            return RedirectToAction("Index");
        }

    }
}