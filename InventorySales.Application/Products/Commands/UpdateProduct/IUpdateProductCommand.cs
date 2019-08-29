using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Commands.UpdateProduct
{
    public interface IUpdateProductCommand
    {
        void Execute(UpdateProductModel updateProductModel);
    }
}
