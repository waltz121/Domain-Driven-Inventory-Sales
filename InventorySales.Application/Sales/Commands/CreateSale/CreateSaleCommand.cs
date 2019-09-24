using InventorySales.Application.Interfaces;
using InventorySales.Application.Sales.Factory;

namespace InventorySales.Application.Sales.Commands.CreateSale
{
    public class CreateSaleCommand : ICreateSaleCommand
    {
        private readonly IDatabaseService databaseService;
        private readonly ISaleFactory saleFactory;
        public CreateSaleCommand(IDatabaseService databaseService, ISaleFactory saleFactory)
        {
            this.databaseService = databaseService;
            this.saleFactory = saleFactory;
        }
        public void Execute(CreateSaleModel createSale)
        {
            var Sale = saleFactory.CreateSale();
            Sale.Id = createSale.Id;
            Sale.Date_of_Sale = createSale.DateOfSale;
            Sale.Total_Amount_of_Sale = createSale.TotalAmountOfSale;

            var ListProductsInSales = saleFactory.CreateListProductsInSales();

            foreach (var i in createSale.Products)
            {
                var productInSales = saleFactory.CreateProductsInSales();
                productInSales.Product_Id = i.ProductId;
                productInSales.Quantity = i.Quantity;
                productInSales.Sales_Id = Sale.Id;
                ListProductsInSales.Add(productInSales);
            }

            Sale.Products_In_Sales = ListProductsInSales;

            databaseService.Sales.Add(Sale);
            databaseService.Save();
        }
    }
}
