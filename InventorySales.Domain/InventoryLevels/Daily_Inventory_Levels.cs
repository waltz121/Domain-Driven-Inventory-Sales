using InventorySales.Domain.CalendarReference;
using InventorySales.Domain.Common;
using InventorySales.Domain.Products;
using System;
using System.Collections.Generic;

namespace InventorySales.Domain.InventoryLevels
{
    public class Daily_Inventory_Levels :IEntity
    {
        public DateTime Day_Date { get; set; }
        public int Product_ID { get; set; }
        public int Quantity { get; set; }
        public int Id { get; set; }
    }
}
