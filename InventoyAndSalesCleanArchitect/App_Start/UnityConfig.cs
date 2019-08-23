using InventorySales.Application.Interfaces;
using InventorySales.Application.Sales.Queries.GetSalesQueries;
using InventorySales.Persistence;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace InventoyAndSalesCleanArchitect
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IDatabaseService, InventorySystemsDatabaseService>();
            container.RegisterType<IGetSalesQuery, GetSalesQuery>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}