using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InventorySales.Application.Products.Commands.CreateProductTypes;
using InventoyAndSalesCleanArchitect.ProductTypeCode.Model;

namespace InventoyAndSalesCleanArchitect.ProductTypeCode.Services
{
    public class CreateProductTypeViewModelFactory : ICreateProductTypeViewModelFactory
    {

        public CreateProductTypeViewModel Create()
        {
            CreateProductTypeViewModel ViewModel = new CreateProductTypeViewModel();
            ViewModel.createProductTypesModel = new CreateProductTypesModel();

            return ViewModel;
        }
    }
}