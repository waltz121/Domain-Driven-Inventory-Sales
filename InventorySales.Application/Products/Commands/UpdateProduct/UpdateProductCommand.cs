using InventorySales.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IUpdateProductCommand
    {
        private readonly IDatabaseService database;
        public UpdateProductCommand(IDatabaseService database)
        {
            this.database = database;
        }
        public void Execute(UpdateProductModel updateProductModel)
        {
            var product = database.Product.Where(x => x.Id == updateProductModel.ProductID).Single();
            product.Product_Type_Code = updateProductModel.ProductTypeCode;
            product.Product_Name = updateProductModel.ProductName;
            product.Unit_Price = updateProductModel.UnitPrice;
            product.Product_Description = updateProductModel.ProductDescription;
            product.Reorder_Level = updateProductModel.ReorderLevel;
            product.Other_Details = updateProductModel.OtherDetails;      
            
            database.Update(product);
            database.Save();
        }
    }
}
