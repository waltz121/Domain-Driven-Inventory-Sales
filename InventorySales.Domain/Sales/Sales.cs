using InventorySales.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Domain.Sales
{
    public class Sales : IEntity
    {
        public int Id { get; set; }
        public DateTime? Date_of_Sale { get; set; }
        public float? Total_Amount_of_Sale { get; set; }
    }
}
