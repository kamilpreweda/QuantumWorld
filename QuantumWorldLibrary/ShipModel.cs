using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldLibrary
{
    public class ShipModel
    {
        public string ShipName { get; set; }
        public string ShipDescription { get; set; }
        public int ShipQuantity { get; set; }
        public int ShipCost { get; set; }
        public DateTime ShipTimeToUpgrade { get; set; }
        public int ShipPower { get; set; }
    }
}
