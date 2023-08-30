using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PlantvilleEmrecanOzkan
{
    [DataContract]
    class Plant
    {
        [DataMember]
        private Seed PlantedSeed { get; set; }
        [DataMember]
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
        public void SetPlantedTime(DateTime plantedTime)
        {
            PlantedTime = plantedTime;
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
