using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventorySales.Application.Products.Queries.GetProductDetails;
using InventorySales.Application.Products.Queries.GetProductList;
using InventorySales.Application.Sales.Commands.CreateSale;
using InventoyAndSalesCleanArchitect.Sale.Model;

namespace InventoyAndSalesCleanArchitect.Sale.Services
{
    public class CreateSaleViewModelFactory : ICreateSaleViewModelFactory
    {
        private readonly IGetProductListQuery getProductListQuery;
        public CreateSaleViewModelFactory(IGetProductListQuery getProductListQuery)
        {
            this.getProductListQuery = getProductListQuery;
        }
        public CreateSaleViewModel createSaleViewModel()
        {
            CreateSaleViewModel viewModel = new CreateSaleViewModel();
            viewModel.createSaleModel = new CreateSaleModel();
            viewModel.Products = new List<SelectListItem>();
            viewModel.AddedProducts = new List<ProductListItemModel>();

            var ProductList = getProductListQuery.Execute();
            foreach(var i in ProductList)
            {
                SelectListItem item = new SelectListItem();
                item.Text = i.ProductName;
                item.Value = i.ProductID.ToString();
                viewModel.Products.Add(item);
            }

            return viewModel;
        }
    }
}