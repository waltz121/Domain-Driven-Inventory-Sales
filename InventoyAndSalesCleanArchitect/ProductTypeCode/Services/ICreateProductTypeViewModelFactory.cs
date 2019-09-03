using InventoyAndSalesCleanArchitect.ProductTypeCode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoyAndSalesCleanArchitect.ProductTypeCode.Services
{
    public interface ICreateProductTypeViewModelFactory
    {
        CreateProductTypeViewModel Create();
    }
}
