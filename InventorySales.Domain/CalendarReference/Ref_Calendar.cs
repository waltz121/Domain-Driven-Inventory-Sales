using InventorySales.Domain.Common;
using InventorySales.Domain.InventoryLevels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Domain.CalendarReference
{
    public class Ref_Calendar
    {
        [Key]
        public DateTime Day_Date { get; set; }
        public ICollection<Daily_Inventory_Levels> Daily_Inventory_Levels { get; set; }
    }
}