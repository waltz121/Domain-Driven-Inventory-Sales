using InventorySales.Application.Interfaces;
using InventorySales.Application.Products.Queries.GetProductDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Sales.Queries.GetSaleDetails
{
    public class GetSaleDetailsQuery : IGetSaleDetailsQuery
    {
        private readonly IDatabaseService databaseService;
        public GetSaleDetailsQuery(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }
        public SaleDetailsModel Execute(int id)
        {
            List<ProductDetailsModel> productDetailsModels = new List<ProductDetailsModel>();
            var query = (from sp in databaseService.Products_In_Sales
                         join
                               p in databaseService.Product on sp.Product_Id 
                         equals p.Id
                         select p).AsEnumerable()
                         .Select(x => new ProductDetailsModel()
                         {
                             ProductID = x.Id,
                             ProductName = x.Product_Name,
                             ProductTypeCode = x.Product_Type_Code,
                             UnitPrice = x.Unit_Price,
                             ProductDescription = x.Product_Description,
                             ReorderLevel = x.Reorder_Level,
                             ReorderQuantity = x.Reorder_Quantity,
                             OtherDetails = x.Other_Details
                         }).ToList();

            var saleDetail = databaseService.Sales.Select(x => new SaleDetailsModel()
            {
                 Id = x.Id,
                 TotalAmountOfSale = x.Total_Amount_of_Sale,
                 DateOfSale = x.Date_of_Sale,
                 Products = productDetailsModels
            }).SingleOrDefault();

            return saleDetail;
        }
    }
}
