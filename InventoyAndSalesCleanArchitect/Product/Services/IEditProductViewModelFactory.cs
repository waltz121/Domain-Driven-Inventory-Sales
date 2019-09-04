using InventoyAndSalesCleanArchitect.Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoyAndSalesCleanArchitect.Product.Services
{
    public interface IEditProductViewModelFactory
    {
        EditProductViewModel Create(int id);
    }
}
