using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PlantvilleEmrecanOzkan
{
    [DataContract]
    class Seed
    {
        [DataMember]
        protected string Name { get; set; }
        [DataMember]
        private int Price { get; set; }
        [DataMember]
        private int HarvestPrice { get; set; }
        [DataMember]
        private int TimeToHarvest { get; set; } // Seconds
        [DataMember]
        private int TimeToSpoil { get; set; } // Seconds

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public int GetPrice()
        {
            return Price;
        }

        public void SetPrice(int price)
        {
            Price = price;
        }

        public int GetHarvestPrice()
        {
            return HarvestPrice;
        }

        public void SetHarvestPrice(int price)
        {
            HarvestPrice = price;
        }

        public int GetTimeToHarvest()
        {
            return TimeToHarvest;
        }

        public void SetTimeToHarvest(int time)
        {
            TimeToHarvest = time;
        }

        public int GetTimeToSpoil()
        {
            return TimeToSpoil;
        }

        public void SetTimeToSpoil(int time)
        {
            TimeToSpoil = time;
        }

    }
}
