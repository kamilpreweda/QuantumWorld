using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldLibrary
{
    public class BuildingModel
    {
        public string BuildingName { get; set; }
        public string BuildingDescription { get; set; }
        public int BuildingLevel { get; set; }
        public DateTime BuildingTimeToUpgrade { get; set; }
        public int BuildingResourceMultiplier { get; set; }
        public List<ResourceModel> BuildingCost { get; set; }
    }



}
