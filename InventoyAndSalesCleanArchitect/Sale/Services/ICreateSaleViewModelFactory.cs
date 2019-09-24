using InventoyAndSalesCleanArchitect.Sale.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoyAndSalesCleanArchitect.Sale.Services
{
    public interface ICreateSaleViewModelFactory
    {
        CreateSaleViewModel createSaleViewModel();
    }
}
