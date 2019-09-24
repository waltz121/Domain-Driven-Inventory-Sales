using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Sales.Queries.GetSaleDetails
{
    public interface IGetSaleDetailsQuery
    {
        SaleDetailsModel Execute(int id);
    }
}
