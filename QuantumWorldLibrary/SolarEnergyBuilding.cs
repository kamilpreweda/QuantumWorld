using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldLibrary
{
    public class SolarEnergyBuilding : BuildingModel
    {

        public SolarEnergyBuilding()
        {
            BuildingName = "Solar Energy Building";
            BuildingDescription = "Solar Energy Building Description";
            BuildingLevel = 0;
            BuildingCost = new List<ResourceModel>()
            {
                new CarbonFiberResource(),
                new QuantumGlassResource(),
                new HiggsBosonResource(),
                new SolarEnergyResource(),
            };

        }
    }
}
