using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldLibrary
{
    public class CarbonFiberBuilding : BuildingModel
    {
     
        public CarbonFiberBuilding()
        {
            BuildingName = "CarbonFiberBuilding";
            BuildingDescription = "CarbonFiberBuilding DESC";
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
