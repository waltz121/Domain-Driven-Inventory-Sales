using InventorySales.Application.Products.Commands.CreateProduct;
using InventoyAndSalesCleanArchitect.Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoyAndSalesCleanArchitect.Product.Services
{
    public interface ICreateProductViewModelFactory
    {
        CreateProductViewModel Create();
    }
}
