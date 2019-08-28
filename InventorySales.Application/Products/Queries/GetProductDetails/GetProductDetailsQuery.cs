using InventorySales.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Queries.GetProductDetails
{
    public class GetProductDetailsQuery : IGetProductDetailsQuery
    {
        private readonly IDatabaseService database;
        public GetProductDetailsQuery(IDatabaseService database)
        {
            this.database = database;
        }
        public ProductDetailsModel Execute(int ID)
        {
            var Product = database.Product
                            .Where(x => x.Product_ID == ID)
                            .Select(x => new ProductDetailsModel()
                            {
                                ProductID = x.Product_ID,
                                ProductTypeCode = x.Product_Type_Code,
                                ProductName = x.Product_Name,
                                UnitPrice = x.Unit_Price,
                                ProductDescription = x.Product_Description,
                                ReorderLevel = x.Reorder_Level,
                                ReorderQuantity = x.Reorder_Quantity,
                                OtherDetails = x.Other_Details
                            }).Single();

            return Product;
        }
    }
}
