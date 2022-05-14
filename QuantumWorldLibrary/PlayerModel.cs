using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldLibrary
{
    public class PlayerModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Points { get; set; }
        public List<ResourceModel> Resources { get; set; }
        public List<BuildingModel> Buildings { get; set; }
        public List<ResearchModel> Researches { get; set; }
        public List<ShipModel> Ships { get; set; }
        public List<VillainModel> Map { get; set; }
    }
}
