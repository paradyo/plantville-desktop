using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantvilleEmrecanOzkan
{
    class SeedsEmporium: ISellASeed
    {
        public List<Seed> Seeds { get; set; }
        public SeedsEmporium()
        {
            Seeds = new List<Seed>()
            {
                new Strawberry(),
                new Pear(),
                new Spinach(),
                new Strawberry(),
                new Pear(),
                new Spinach(),
                new Strawberry(),
                new Pear(),
                new Spinach()
            };
        }
        public void SellASeed(Seed seed)
        {
            Seeds.RemoveAt(Seeds.IndexOf(seed));
        }
        public void AddSeed(Seed seed)
        {
            Seeds.Add(seed);
        }
    }
}
