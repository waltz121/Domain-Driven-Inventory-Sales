using InventorySales.Domain.CalendarReference;
using InventorySales.Domain.InventoryLevels;
using InventorySales.Domain.Products;
using InventorySales.Domain.ProductsInSales;
using InventorySales.Domain.ProductTypes;
using InventorySales.Domain.Sales;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Interfaces
{
    public interface IDatabaseService
    {
        IDbSet<Sale> Sale { get; set; }
        IDbSet<Product_Types> Product_Types { get; set; }
        IDbSet<Products_in_Sales> Products_In_Sales { get; set; }
        IDbSet<Product> Product { get; set; }
        IDbSet<Daily_Inventory_Levels> Daily_Inventory_Levels { get; set; }
        IDbSet<Ref_Calendar> Ref_Calendars { get; set; }

        void Delete(object DeletedEntity);
        void Update(object updateEntity);
        void Save();
    }
}
