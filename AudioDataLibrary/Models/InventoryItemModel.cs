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
        public int ItemId { get; set; }
        public string code { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string? Variant { get; set; }
        public string? Description { get; set; }
        public int Count {  get; set; }
        public int WarrantyMonths { get; set; }
        public double UnitPricePHP { get; set; }

    }
}
