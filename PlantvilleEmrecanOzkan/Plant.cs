using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantvilleEmrecanOzkan
{
    class Plant
    {
        private Seed PlantedSeed { get; set; }
        private DateTime PlantedTime { get; set; }
        public Plant(Seed seed)
        {
            PlantedSeed = seed;
            PlantedTime = DateTime.Now;
        }
        public Seed GetPlantedSeed()
        {
            return PlantedSeed;
        }
        public bool IsItTimeToSpoil()
        {
            TimeSpan timePassed = DateTime.Now - PlantedTime;
            return timePassed.TotalSeconds >= PlantedSeed.GetTimeToSpoil();
        }
        public bool IsItTimeToHarvest()
        {
            TimeSpan timePassed = DateTime.Now - PlantedTime;
            return timePassed.TotalSeconds >= PlantedSeed.GetTimeToHarvest();
        }
        public int GetTotalPassedSeconds()
        {
            TimeSpan timePassed = DateTime.Now - PlantedTime;
            return Convert.ToInt32(timePassed.TotalSeconds);
        }
        public int GetTotalLeftSeconds(int target)
        {
            return target - GetTotalPassedSeconds();
        }
    }
}
