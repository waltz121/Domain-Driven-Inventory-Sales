using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Queries.GetProductDetails
{
    public interface IGetProductDetailsQuery
    {
        ProductDetailsModel Execute(int ID);
    }
}
