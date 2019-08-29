using InventorySales.Application.Interfaces;
using InventorySales.Application.Products.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommand : ICreateProductCommand
    {
        private readonly IDatabaseService database;
        private readonly IProductFactory factory;

        public CreateProductCommand(IDatabaseService database, IProductFactory factory)
        {
            this.database = database;
            this.factory = factory;
        }

        public void Execute(CreateProductModel createProductModel)
        {

            var product = factory.CreateProduct();
            product.Product_ID = createProductModel.ProductID;
            product.Product_Type_Code = createProductModel.ProductTypeCode;
            product.Product_Name = createProductModel.ProductName;
            product.Unit_Price = createProductModel.UnitPrice;
            product.Product_Description = createProductModel.ProductDescription;
            product.Reorder_Level = createProductModel.ReorderLevel;
            product.Reorder_Quantity = createProductModel.ReorderQuantity;
            product.Other_Details = createProductModel.OtherDetails;

            database.Product.Add(product);

            database.Save();
        }
    }
}