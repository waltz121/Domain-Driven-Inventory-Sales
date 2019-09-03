using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Commands.UpdateProductTypes
{
    public interface IUpdateProductTypesCommand
    {
        void Execute(UpdateProductTypesModel model);
    }
}
