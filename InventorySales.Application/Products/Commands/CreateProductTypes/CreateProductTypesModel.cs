using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.Application.Products.Commands.CreateProductTypes
{
    public class CreateProductTypesModel
    {
        public int ProductTypeCode { get; set; }
        public int? ParentProductTypeCode { get; set; }
        public string ProductTypeDescription { get; set; }
    }
}
