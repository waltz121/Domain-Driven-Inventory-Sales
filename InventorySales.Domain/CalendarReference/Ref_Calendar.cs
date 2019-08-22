using InventorySales.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Domain.CalendarReference
{
    class Ref_Calendar: IEntity
    {
        public DateTime Day_Date { get; set; }
        public int Id { get; set; }
    }
}
