using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Queries.GetProductTypesDetails
{
    public interface IGetProductTypesDetailsQuery
    {
        GetProductTypesDetailModel Execute();
    }
}
