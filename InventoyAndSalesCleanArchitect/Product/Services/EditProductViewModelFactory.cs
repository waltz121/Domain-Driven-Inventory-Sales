using InventorySales.Application.Products.Commands.UpdateProduct;
using InventorySales.Application.Products.Queries.GetProductDetails;
using InventorySales.Application.Products.Queries.GetProductTypesList;
using InventoyAndSalesCleanArchitect.Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoyAndSalesCleanArchitect.Product.Services
{
    public class EditProductViewModelFactory : IEditProductViewModelFactory
    {
        private readonly IGetProductTypesListQuery getProductTypesListQuery;
        private readonly IGetProductDetailsQuery getProductDetailsQuery;
        public EditProductViewModelFactory(IGetProductTypesListQuery getProductTypesListQuery, IGetProductDetailsQuery getProductDetailsQuery)
        {
            this.getProductTypesListQuery = getProductTypesListQuery;
            this.getProductDetailsQuery = getProductDetailsQuery;
        }
        public EditProductViewModel Create(int id)
        {
            EditProductViewModel viewModel = new EditProductViewModel();
            viewModel.UpdateProductModel = new UpdateProductModel();

            var productDetails = getProductDetailsQuery.Execute(id);
            viewModel.ProductDetailsModel = productDetails;

            viewModel.UpdateProductModel.ProductID = productDetails.ProductID;
            viewModel.UpdateProductModel.ProductName = productDetails.ProductName;
            viewModel.UpdateProductModel.ProductTypeCode = productDetails.ProductTypeCode;
            viewModel.UpdateProductModel.OtherDetails = productDetails.OtherDetails;
            viewModel.UpdateProductModel.ProductDescription = productDetails.ProductDescription;
            viewModel.UpdateProductModel.ReorderLevel = productDetails.ReorderLevel;
            viewModel.UpdateProductModel.ReorderQuantity = productDetails.ReorderQuantity;
            viewModel.UpdateProductModel.UnitPrice = productDetails.UnitPrice;

            var productTypesList = getProductTypesListQuery.Execute();

            viewModel.productTypesList = productTypesList.Select(p => new SelectListItem()
            {
                Value = p.ProductTypeCode.ToString(),
                Text = p.ProductTypeDescription.ToString()
            })
            .ToList();


            return viewModel;
        }
    }
}