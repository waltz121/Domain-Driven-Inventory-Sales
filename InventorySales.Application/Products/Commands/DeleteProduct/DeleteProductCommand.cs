using InventorySales.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IDeleteProductCommand
    {
        private readonly IDatabaseService database;
        public DeleteProductCommand(IDatabaseService database)
        {
            this.database = database;
        }
        public void Execute(int ID)
        {
            var product = database.Product.Where(x => x.Product_ID == ID).Single();

            database.Delete(product);
            database.Save();
        }
    }
}