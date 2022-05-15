using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldLibrary
{
    public class QuantumGlassResource : ResourceModel
    { 
        public QuantumGlassResource()
        {
            ResourceName = "Quantum Glass";
            ResourceValue = 250;
            ResourceBaseStat = 250;
            ResourceMultiplier = (float)1.15;
        }
    }
}

