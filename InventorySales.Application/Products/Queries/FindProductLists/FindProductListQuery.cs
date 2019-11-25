using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using InventorySales.Application.Interfaces;
using InventorySales.Application.Products.Queries.GetProductList;
using InventorySales.Domain.Products;

namespace InventorySales.Application.Products.Queries.FindProductLists
{
    public class FindProductListQuery : IFindProductListQuery
    {
        private readonly IDatabaseService database;

        public FindProductListQuery(IDatabaseService database)
        {
            this.database = database;
        }
        public IQueryable<ProductListItemModel> Execute(int id)
        {
            var product = database.Product
                 .Where(x=> x.Id == id)
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

            return product;
        }
    }
}