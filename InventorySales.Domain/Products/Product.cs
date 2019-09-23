using InventorySales.Domain.Common;
using InventorySales.Domain.InventoryLevels;
using InventorySales.Domain.ProductsInSales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Domain.Products
{
    public class Product: IEntity
    {
        public int Product_Type_Code { get; set; }
        public string Product_Name { get; set; }
        public decimal Unit_Price { get; set; }
        public string Product_Description { get; set; }
        public int? Reorder_Level { get; set; }
        public int? Reorder_Quantity { get; set; }
        public string Other_Details { get; set; }
        public virtual ICollection<Products_in_Sales> Products_In_Sales { get; set; }
        public virtual ICollection<Daily_Inventory_Levels> Daily_Inventory_Levels { get; set; }
        public int Id { get; set; }
    }
}
