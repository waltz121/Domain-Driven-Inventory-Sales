using InventorySales.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Queries.GetProductTypesList
{
    public class GetProductTypesListQuery : IGetProductTypesListQuery
    {
        private readonly IDatabaseService database;
        public GetProductTypesListQuery(IDatabaseService database)
        {
            this.database = database;
        }
        public List<GetProductTypesListModel> Execute()
        {
            var ProductTypes = database.Product_Types
                .Select(x => new GetProductTypesListModel()
                {
                    ProductTypeCode = x.Product_Type_Code,
                    ParentProductTypeCode = x.Parent_Product_Type_Code,
                    ProductTypeDescription = x.Product_Type_Description
                });

            return ProductTypes.ToList();
        }
    }
}
