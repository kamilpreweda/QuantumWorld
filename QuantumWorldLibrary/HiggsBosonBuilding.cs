using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldLibrary
{
    public class HiggsBosonBuilding : BuildingModel
    {

        public HiggsBosonBuilding()
        {
            BuildingName = "Higgs Boson Building";
            BuildingDescription = "Higgs Boson Building Description";
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
