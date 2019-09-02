using System;
using InventorySales.Application.Products.Commands.CreateProduct;
using InventoyAndSalesCleanArchitect.Product.Model;

namespace InventoyAndSalesCleanArchitect.Product.Services
{
    public class CreateProductViewModelFactory : ICreateProductViewModelFactory
    {
        public CreateProductViewModel Create()
        {
            CreateProductViewModel ViewModel = new CreateProductViewModel();
            ViewModel.createProductModel = new CreateProductModel();

            return ViewModel;
        }
    }
}