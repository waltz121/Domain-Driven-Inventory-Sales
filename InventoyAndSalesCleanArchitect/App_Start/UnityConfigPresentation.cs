﻿using InventoyAndSalesCleanArchitect.Product.Services;
using InventoyAndSalesCleanArchitect.ProductTypeCode.Services;
using InventoyAndSalesCleanArchitect.Sale.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace InventoyAndSalesCleanArchitect.App_Start
{
    public static class UnityConfigPresentation
    {
        public static void RegisterComponents(UnityContainer container)
        {
            container.RegisterType<ICreateSaleViewModelFactory, CreateSaleViewModelFactory>();
            container.RegisterType<ICreateProductViewModelFactory, CreateProductViewModelFactory>();
            container.RegisterType<ICreateProductTypeViewModelFactory, CreateProductTypeViewModelFactory>();
            container.RegisterType<IEditProductViewModelFactory, EditProductViewModelFactory>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}