using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Commands.DeleteProductTypes
{
    public interface IDeleteProductTypesCommand
    {
        void Execute(int code);
    }
}
