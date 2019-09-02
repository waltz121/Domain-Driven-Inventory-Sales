using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Queries.GetProductTypesList
{
    public interface IGetProductTypesListQuery
    {
        List<GetProductTypesListModel> Execute();
    }
}
