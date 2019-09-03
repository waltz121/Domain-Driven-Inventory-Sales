using InventorySales.Application.Interfaces;
using InventorySales.Application.Products.Factory;
using System;
using System.Linq;

namespace InventorySales.Application.Products.Commands.UpdateProductTypes
{
    public class UpdateProductTypesCommand : IUpdateProductTypesCommand
    {
        private readonly IDatabaseService database;

        public UpdateProductTypesCommand(IDatabaseService database)
        {
            this.database = database;
        }
        public void Execute(UpdateProductTypesModel model)
        {
            var productType = database.Product_Types.Where(x => x.Product_Type_Code == model.ProductTypeCode).Single();
            productType.Parent_Product_Type_Code = model.ParentProductTypeCode;
            productType.Product_Type_Description = model.ProductTypeDescription;

            database.Update(productType);
            database.Save();
        }
    }
}
