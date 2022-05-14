using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldLibrary
{
    public class VillainModel
    {
        public string VillainName { get; set; }
        public string VillainDescription { get; set; }
        public List<ShipModel> VillainShips { get; set; }
        public DateTime VillainTimeToAttack { get; set; }
        public List<RewardModel> VillainRewards { get; set; }
    }
}
