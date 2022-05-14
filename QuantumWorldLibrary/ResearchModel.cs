using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldLibrary
{
    public class ResearchModel
    {
        public string ResearchName { get; set; }
        public string ResearchDescription { get; set; }
        public int ResearchLevel { get; set; }
        public int ResearchCost { get; set; }
        public DateTime ResearchTimeToUpgrade { get; set; }
        public DateTime ResearchBuildingTimeMultiplier { get; set; }
        public int ResearchResourceMultiplier { get; set; }
        public DateTime ResearchShipBuildTimeMultiplier { get; set; }
        public int ResearchShipPowerMultiplier { get; set; }
        public DateTime ResearchTravelTimeMultiplier { get; set; }
    }
}
