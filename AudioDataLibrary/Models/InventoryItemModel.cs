using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDataLibrary.Models
{
    public class InventoryItemModel
    {
        public int Id { get; }
        public ItemModel Item { get; set; }
        public int Count {  get; set; }
        public int WarrantyMonths { get; set; }
        public double UnitPricePHP { get; set; }

    }
}
