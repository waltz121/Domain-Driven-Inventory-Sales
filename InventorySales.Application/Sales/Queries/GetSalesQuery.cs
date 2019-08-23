using InventorySales.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Sales.Queries
{
    public class GetSalesQuery : IGetSalesQuery
    {
        private readonly IDatabaseService database;

        public GetSalesQuery(IDatabaseService database)
        {
            this.database = database;
        }
        public List<SalesModel> Execute()
        {
            var Sale = database.Sale
                .Select(x => new SalesModel()
                {
                    Sales_ID = x.Sales_ID,
                    TotalAmountOfSale = x.Total_Amount_of_Sale,
                    DateOfSale = x.Date_of_Sale
                });

            return Sale.ToList();
        }
    }
}
