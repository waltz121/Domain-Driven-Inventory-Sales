using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Queries.GetProductList
{
    public interface IGetProductListQuery
    {
        List<ProductListItemModel> Execute();
    }
}
