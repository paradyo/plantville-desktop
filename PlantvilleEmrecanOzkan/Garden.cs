using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantvilleEmrecanOzkan
{
    class Garden
    {
        private List<Plant> Plants { get; set; }
        public Garden()
        {
            Plants = new List<Plant>();
        }
        public Garden(List<Plant> plants)
        {
            Plants = plants;
        }
        public List<Plant> GetPlants()
        {
            return Plants;
        }
        public void AddPlant(Plant plant)
        {
            Plants.Add(plant);
        }
        public void RemovePlant(Plant plant)
        {
            Plants.RemoveAt(Plants.IndexOf(plant));
        }
    }
}
