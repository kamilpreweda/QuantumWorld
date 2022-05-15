using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldLibrary
{
    public class QuantumGlassBuilding : BuildingModel
    {

        public QuantumGlassBuilding()
        {
            BuildingName = "Quantum Glass Building";
            BuildingDescription = "Quantum Glass Building Description";
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

    
