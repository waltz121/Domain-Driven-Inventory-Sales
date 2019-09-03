using InventorySales.Application.Interfaces;
using InventorySales.Application.Products.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Commands.CreateProductTypes
{
    public class CreateProductTypesCommand : ICreateProductTypesCommand
    {
        private readonly IDatabaseService database;
        private readonly IProductFactory factory;
        public CreateProductTypesCommand(IDatabaseService database, IProductFactory factory)
        {
            this.database = database;
            this.factory = factory;
        }
        public void Execute(CreateProductTypesModel model)
        {
            var product = factory.CreateProductTypes();
            product.Product_Type_Code = model.ProductTypeCode;
            product.Parent_Product_Type_Code = model.ParentProductTypeCode;
            product.Product_Type_Description = model.ProductTypeDescription;

            database.Product_Types.Add(product);
        }
    }
}
