using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldLibrary
{
    public class RobotFactoryBuilding : BuildingModel
    {

        public RobotFactoryBuilding()
        {
            BuildingName = "Robot FactoryBuilding";
            BuildingDescription = "Robot Factory Building Description";
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
