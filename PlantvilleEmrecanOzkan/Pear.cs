using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantvilleEmrecanOzkan
{
    class Pear: Seed
    {
        public Pear()
        {
            SetName("Pear");
            SetPrice(2);
            SetHarvestPrice(20);
            SetTimeToHarvest(180);
            SetTimeToSpoil(900);
        }
    }
}
