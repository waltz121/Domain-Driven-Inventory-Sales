using InventorySales.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Commands.DeleteProductTypes
{
    public class DeleteProductTypesCommand : IDeleteProductTypesCommand
    {
        private readonly IDatabaseService database;
        public DeleteProductTypesCommand(IDatabaseService database)
        {
            this.database = database;
        }
        public void Execute(int code)
        {
            var productTypes = database.Product_Types.Where(x => x.Product_Type_Code == code).Single();

            database.Delete(productTypes);
            database.Save();
        }
    }
}
