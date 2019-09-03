using System;
using System.Linq;
using System.Web.Mvc;
using InventorySales.Application.Products.Commands.CreateProduct;
using InventorySales.Application.Products.Queries.GetProductTypesList;
using InventoyAndSalesCleanArchitect.Product.Model;

namespace InventoyAndSalesCleanArchitect.Product.Services
{
    public class CreateProductViewModelFactory : ICreateProductViewModelFactory
    {
        private readonly IGetProductTypesListQuery getProductTypesListQuery;
        public CreateProductViewModelFactory(IGetProductTypesListQuery getProductTypesListQuery)
        {
            this.getProductTypesListQuery = getProductTypesListQuery;
        }
        public CreateProductViewModel Create()
        {
            CreateProductViewModel ViewModel = new CreateProductViewModel();
            ViewModel.createProductModel = new CreateProductModel();

            var ProductTypesList = getProductTypesListQuery.Execute();

            ViewModel.productTypesList = ProductTypesList.Select(p => new SelectListItem()
            {
                Value = p.ProductTypeCode.ToString(),
                Text = p.ProductTypeDescription.ToString()
            })
            .ToList();

            return ViewModel;
        }
    }
}