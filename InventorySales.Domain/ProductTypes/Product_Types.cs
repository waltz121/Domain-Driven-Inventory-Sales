using InventorySales.Domain.Common;
using InventorySales.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Domain.ProductTypes
{
    public class Product_Types : IEntity
    {
        public int Id { get; set; }
        public int? Parent_Product_Type_Code { get; set; }
        public string Product_Type_Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
