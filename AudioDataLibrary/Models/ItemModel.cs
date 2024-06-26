using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AudioDataLibrary.Models
{
    public class ItemModel
    {
        public int Id { get; }
        public string Code { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string? Variant { get; set; }
        public string? Description { get; set; }
        public double? Msrp { get; set; }
        public Image? Image { get; set; }
        public List<ConnectorModel>? InputConnectors { get; set; }
        public List<ConnectorModel>? OutputConnectors { get; set; }

    }
}
