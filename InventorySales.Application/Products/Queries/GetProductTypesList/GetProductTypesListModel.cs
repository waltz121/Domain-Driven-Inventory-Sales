using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Queries.GetProductTypesList
{
    public class GetProductTypesListModel
    {
        public int ProductTypeCode { get; set; }
        public int? ParentProductTypeCode { get; set; }
        public string ProductTypeDescription { get; set; }
    }
}
