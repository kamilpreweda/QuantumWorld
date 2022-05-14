using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldLibrary
{
    public class CarbonFiberBuilding : BuildingModel
    {
        public string BuildingName = "CarbonFiberBuilding";
        public string BuildingDescription = "CarbonFiberBuilding DESC";
        public int BuildingLevel = 0;
        public List<ResourceModel> BuildingCost;


        public CarbonFiberBuilding()
        {
            BuildingName = "CarbonFiberBuilding";
            BuildingDescription = "CarbonFiberBuilding DESC";
            BuildingLevel = 0;
            BuildingCost = new List<ResourceModel>()
            {
                new CarbonFiberResource()
            };

    }
            
    }

  

}
