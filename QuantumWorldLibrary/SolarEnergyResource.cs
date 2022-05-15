using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldLibrary
{
    public class SolarEnergyResource : ResourceModel
    {
        public SolarEnergyResource()
        {
            ResourceName = "Solar Energy";
            ResourceValue = 100;
            ResourceBaseStat = 100;
            ResourceMultiplier = (float)1.15;
        }
    }
}
