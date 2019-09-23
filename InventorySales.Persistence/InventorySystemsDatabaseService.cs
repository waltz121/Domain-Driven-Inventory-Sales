using InventorySales.Application.Interfaces;
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

namespace InventorySales.Persistence
{
    public class InventorySystemsDatabaseService: DbContext, IDatabaseService
    {
        public IDbSet<Sale> Sales { get; set; }
        public IDbSet<Product_Types> Product_Types { get; set; }
        public IDbSet<Products_in_Sales> Products_In_Sales { get; set; }
        public IDbSet<Product> Product { get; set; }
        public IDbSet<Daily_Inventory_Levels> Daily_Inventory_Levels { get; set; }
        public IDbSet<Ref_Calendar> Ref_Calendars { get; set; }
        public void Update(object updateEntity)
        {
            this.Entry(updateEntity).State = EntityState.Modified;
        }
        public void Save()
        {               
            this.SaveChanges();
        }
        public void Delete(object DeletedEntity)
        {
            this.Entry(DeletedEntity).State = EntityState.Deleted;
        }
    }
}
