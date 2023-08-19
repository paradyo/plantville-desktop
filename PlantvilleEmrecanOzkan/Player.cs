using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantvilleEmrecanOzkan
{
    class Player: IPurchaseASeed, IPlantASeed, IHarvestAPlant, IThrowAPlant, IHarvestAllPlants, ISellAPlant, ISellAllPlants
    {
        private int Money { get; set; }
        private int LandPlots { get; set; }
        public Inventory Inventory { get; set; }
        public Player()
        {
            Money = 100;
            LandPlots = 15;
            Inventory = new Inventory();
        }
        public int GetMoney()
        {
            return Money;
        }
        public int GetLandPlots()
        {
            return LandPlots;
        }
        public bool BuySeed(Seed seed)
        {
            if (Money < seed.GetPrice())
            {
                return false;
            }
            Money -= seed.GetPrice();
            return true;
        }
        public bool PlantASeed(Garden garden, Seed seed)
        {
            if (LandPlots == 0)
            {
                return false;
            }
            garden.AddPlant(new Plant(seed));
            LandPlots--;
            return true;
        }
        public void GetRefund(int money)
        {
            Money += money;
        }
        public void HarvestAPlant(Plant plant, Garden garden)
        {
            garden.RemovePlant(plant);
            LandPlots++;
            Inventory.AddHarvestedPlant(plant);
        }
        public void ThrowAPlant(Plant plant, Garden garden)
        {
            garden.RemovePlant(plant);
            LandPlots++;
        }
        public void HarvestAllPlants(Garden garden)
        {
            foreach (Plant plant in garden.GetPlants().ToList())
            {
                if (plant.IsItTimeToSpoil())
                {
                    ThrowAPlant(plant, garden);
                    LandPlots++;
                }
                else if (plant.IsItTimeToHarvest())
                {
                    HarvestAPlant(plant, garden);
                    LandPlots++;
                }
            }
        }
        public bool GoToMarket()
        {
            if (Money < 10)
            {
                return false;
            }
            Money -= 10;
            return true;
        }
        public bool SellAPlant(Plant plant) 
        {
            if (GoToMarket())
            {
                Money += plant.GetPlantedSeed().GetHarvestPrice();
                Inventory.RemoveHarvestedPlant(plant);
                return true;
            }
            return false;
        }
        public bool SellAllPlants()
        {
            if (GoToMarket())
            {
                foreach (Plant plant in Inventory.GetHarvestedPlants().ToList())
                {
                    Money += plant.GetPlantedSeed().GetHarvestPrice();
                    Inventory.RemoveHarvestedPlant(plant);
                }
                return true;
            }
            return false;
        }
    }
}
