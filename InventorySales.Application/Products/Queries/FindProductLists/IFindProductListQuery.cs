using InventorySales.Application.Products.Queries.GetProductList;
using InventorySales.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Queries.FindProductLists
{
    public interface IFindProductListQuery
    {
        IQueryable<ProductListItemModel> Execute(int id);
    }
}
