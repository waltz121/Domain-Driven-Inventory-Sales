using InventorySales.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Queries.GetProductList
{
    public class GetProductListQuery : IGetProductListQuery
    {
        private readonly IDatabaseService database;

        public GetProductListQuery(IDatabaseService database)
        {
            this.database = database;
        }
        public List<ProductListItemModel> Execute()
        {
            var Product = database.Product
               .Select(x => new ProductListItemModel()
               {
                   ProductID = x.Id,
                   ProductTypeCode = x.Product_Type_Code,
                   ProductName = x.Product_Name,
                   UnitPrice = x.Unit_Price,
                   ProductDescription = x.Product_Description,
                   ReorderLevel = x.Reorder_Level,
                   ReorderQuantity = x.Reorder_Quantity,
                   OtherDetails = x.Other_Details
                  
               });

            return Product.ToList();

        }
    }
}
