using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantvilleEmrecanOzkan
{
    class Inventory
    {
        private List<Plant> HarvestedPlants { get; set; }
        public Inventory()
        {
            HarvestedPlants = new List<Plant>();
        }
        public List<Plant> GetHarvestedPlants()
        {
            return HarvestedPlants;
        }
        public void AddHarvestedPlant(Plant plant)
        {
            HarvestedPlants.Add(plant);
        }
        public void RemoveHarvestedPlant(Plant plant)
        {
            HarvestedPlants.RemoveAt(HarvestedPlants.IndexOf(plant));
        }
    }
}
