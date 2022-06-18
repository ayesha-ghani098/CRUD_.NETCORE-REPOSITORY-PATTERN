using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWC.WebMall.Data.Models
{
    public class ProductWithInvertory
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string WareHouseCode { get; set; }
        public int Inventory { get; set; }
    }
}
