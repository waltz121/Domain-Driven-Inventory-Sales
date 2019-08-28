﻿using InventorySales.Domain.InventoryLevels;
using InventorySales.Domain.ProductsInSales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Queries.GetProductList
{
    public class ProductListItemModel
    {
        public int ProductID { get; set; }
        public int ProductTypeCode { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductDescription { get; set; }
        public int? ReorderLevel { get; set; }
        public int? ReorderQuantity { get; set; }
        public string OtherDetails { get; set; }
        public virtual ICollection<Products_in_Sales> ProductsInSales { get; set; }
        public virtual ICollection<Daily_Inventory_Levels> DailyInventoryLevels { get; set; }
    }
}
