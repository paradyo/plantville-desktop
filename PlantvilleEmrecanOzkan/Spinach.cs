using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantvilleEmrecanOzkan
{
    class Spinach: Seed
    {
        public Spinach()
        {
            SetName("Spinach");
            SetPrice(5);
            SetHarvestPrice(21);
            SetTimeToHarvest(60);
            SetTimeToSpoil(900);
        }
    }
}
