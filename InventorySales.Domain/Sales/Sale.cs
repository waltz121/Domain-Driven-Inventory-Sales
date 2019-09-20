using InventorySales.Domain.Common;
using InventorySales.Domain.ProductsInSales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Domain.Sales
{
    public class Sale: IEntity
    {
        public DateTime? Date_of_Sale { get; set; }
        public double? Total_Amount_of_Sale { get; set; }
        public virtual ICollection<Products_in_Sales> Products_In_Sales { get; set; }
        public int Id { get; set; }
    }
}
