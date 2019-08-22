using InventorySales.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Domain.InventoryLevels
{
    public class Daily_Inventory_Levels : IEntity
    {
        public int Id { get; set; }
        public DateTime Day_Date { get; set; }
        public int Product_ID { get; set; }
        public int Quantity { get; set; }
    }
}
