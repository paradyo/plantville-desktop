using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantvilleEmrecanOzkan
{
    class Strawberry: Seed
    {
        public Strawberry()
        {
            SetName("Strawberry");
            SetPrice(2);
            SetHarvestPrice(8);
            SetTimeToHarvest(30);
            SetTimeToSpoil(900);
        }
    }
}
