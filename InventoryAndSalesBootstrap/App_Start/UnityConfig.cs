using InventorySales.Application.Interfaces;
using InventorySales.Application.Products.Commands.CreateProduct;
using InventorySales.Application.Products.Commands.CreateProductTypes;
using InventorySales.Application.Products.Commands.DeleteProduct;
using InventorySales.Application.Products.Commands.DeleteProductTypes;
using InventorySales.Application.Products.Commands.UpdateProduct;
using InventorySales.Application.Products.Commands.UpdateProductTypes;
using InventorySales.Application.Products.Factory;
using InventorySales.Application.Products.Queries.GetProductDetails;
using InventorySales.Application.Products.Queries.GetProductList;
using InventorySales.Application.Products.Queries.GetProductTypesDetails;
using InventorySales.Application.Products.Queries.GetProductTypesList;
using InventorySales.Application.Sales.Commands.CreateSale;
using InventorySales.Application.Sales.Factory;
using InventorySales.Application.Sales.Queries.GetSaleDetails;
using InventorySales.Application.Sales.Queries.GetSalesList;
using InventorySales.Persistence;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace InventoryAndSalesBootstrap
{
    public static class UnityConfig
    {
        public static UnityContainer RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IGetSaleDetailsQuery, GetSaleDetailsQuery>();
            container.RegisterType<ICreateSaleCommand, CreateSaleCommand>();
            container.RegisterType<ISaleFactory, SaleFactory>();

            container.RegisterType<ICreateProductCommand, CreateProductCommand>();
            container.RegisterType<IGetProductListQuery, GetProductListQuery>();
            container.RegisterType<IGetProductDetailsQuery, GetProductDetailsQuery>();
            container.RegisterType<IUpdateProductCommand, UpdateProductCommand>();
            container.RegisterType<IProductFactory, ProductFactory>();
            container.RegisterType<IDeleteProductCommand, DeleteProductCommand>();

            container.RegisterType<IGetProductTypesListQuery, GetProductTypesListQuery>();
            container.RegisterType<IGetProductTypesDetailsQuery, GetProductTypesDetailQuery>();
            container.RegisterType<ICreateProductTypesCommand, CreateProductTypesCommand>();
            container.RegisterType<IUpdateProductTypesCommand, UpdateProductTypesCommand>();
            container.RegisterType<IDeleteProductTypesCommand, DeleteProductTypesCommand>();            
            
            container.RegisterType<IGetSalesListQuery, GetSalesListQuery>();

            container.RegisterType<IDatabaseService, InventorySystemsDatabaseService>();

            //DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }
    }
}