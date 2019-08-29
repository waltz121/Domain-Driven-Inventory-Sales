using InventorySales.Application.Interfaces;
using InventorySales.Application.Products.Commands.CreateProduct;
using InventorySales.Application.Products.Commands.UpdateProduct;
using InventorySales.Application.Products.Queries.GetProductDetails;
using InventorySales.Application.Products.Queries.GetProductList;
using InventorySales.Application.Sales.Queries.GetSalesList;
using InventorySales.Persistence;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace InventoryAndSalesBootstrap
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICreateProductCommand, CreateProductCommand>();
            container.RegisterType<IGetProductListQuery, GetProductListQuery>();
            container.RegisterType<IGetProductDetailsQuery, GetProductDetailsQuery>();
            container.RegisterType<IUpdateProductCommand, UpdateProductCommand>();
            
            container.RegisterType<IGetSalesListQuery, GetSalesListQuery>();

            container.RegisterType<IDatabaseService, InventorySystemsDatabaseService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}