using InventorySales.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Domain.Products
{
    public class Products : IEntity
    {
        public int Id { get; set; }
        public int Product_Type_Code { get; set; }
        public string Product_Name { get; set; }
        public decimal Unit_Price { get; set; }
        public string Product_Description { get; set; }
        public int? Reorder_Level { get; set; }
        public int? Reorder_Quantity { get; set; }
        public string Other_Details { get; set; }
    }
}
