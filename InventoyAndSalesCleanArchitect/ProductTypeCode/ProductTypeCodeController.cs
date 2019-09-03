using InventorySales.Application.Products.Commands.CreateProductTypes;
using InventorySales.Application.Products.Commands.DeleteProductTypes;
using InventorySales.Application.Products.Queries.GetProductList;
using InventorySales.Application.Products.Queries.GetProductTypesDetails;
using InventorySales.Application.Products.Queries.GetProductTypesList;
using InventoyAndSalesCleanArchitect.ProductTypeCode.Model;
using InventoyAndSalesCleanArchitect.ProductTypeCode.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoyAndSalesCleanArchitect.ProductTypeCode
{
    [RoutePrefix("ProductTypeCode")]
    public class ProductTypeCodeController : Controller
    {
        private readonly IGetProductTypesListQuery getProductTypesListQuery; 
        private readonly IGetProductTypesDetailsQuery getProductTypesDetailsQuery;
        private readonly ICreateProductTypeViewModelFactory productTypeViewModelFactory;
        private readonly ICreateProductTypesCommand createProductTypesCommand;
        private readonly IDeleteProductTypesCommand deleteProductTypesCommand;

        public ProductTypeCodeController(IGetProductTypesDetailsQuery getProductTypesDetailsQuery, IGetProductTypesListQuery getProductTypesListQuery,
                                         ICreateProductTypeViewModelFactory productTypeViewModelFactory, ICreateProductTypesCommand createProductTypesCommand,
                                         IDeleteProductTypesCommand deleteProductTypesCommand)
        {
            this.getProductTypesDetailsQuery = getProductTypesDetailsQuery;
            this.getProductTypesListQuery = getProductTypesListQuery;
            this.productTypeViewModelFactory = productTypeViewModelFactory;
            this.createProductTypesCommand = createProductTypesCommand;
            this.deleteProductTypesCommand = deleteProductTypesCommand;
        }

        // GET: ProductTypeCode
        public ActionResult Index()
        {
            var productTypes = getProductTypesListQuery.Execute();

            return View(productTypes);
        }

        [Route("create")]
        public ActionResult Create()
        {
            var productTypeViewModel = productTypeViewModelFactory.Create();

            return View(productTypeViewModel);
        }

        [Route("create")]
        [HttpPost]
        public ActionResult Create(CreateProductTypeViewModel viewModel)
        {
            createProductTypesCommand.Execute(viewModel.createProductTypesModel);

            return RedirectToAction("Index");
        }

        [Route("delete")]
        public ActionResult Delete(int id)
        {
            deleteProductTypesCommand.Execute(id);

            return RedirectToAction("Index");
        }
    }
}
