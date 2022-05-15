﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldLibrary
{
    public class CarbonFiberResource : ResourceModel
    {
        public CarbonFiberResource()
        {
            ResourceName = "Carbon Fiber";
            ResourceValue = 500;
            ResourceBaseStat = 500;
            ResourceMultiplier = (float)1.15;
        }
    }

   
}
