using InventorySales.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Sales.Queries.GetSalesList
{
    public class GetSalesListQuery : IGetSalesListQuery
    {
        private readonly IDatabaseService database;

        public GetSalesListQuery(IDatabaseService database)
        {
            this.database = database;
        }

        public List<SalesListItemModel> Execute()
        {
            var Sale = database.Sales
             .Select(x => new SalesListItemModel()
             {
                 Sales_ID = x.Id,
                 TotalAmountOfSale = x.Total_Amount_of_Sale,
                 DateOfSale = x.Date_of_Sale
             });

            return Sale.ToList();
        }
    }
}
