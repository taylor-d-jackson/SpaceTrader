using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Earth
    {
        string Name = "Earth";
        string Location;
        string Description;
        int XCoord = 3;
        int YCoord = 1;

        public Earth()
        {

        }

        




        public Earth(string name, string location, string description, int xco, int yco)
        {
            this.Name = name;
            this.Location = location;
            this.Description = description;
            this.XCoord = xco;
            this.YCoord = yco;
        }

        public void EarthGoods()
        {
            List<GoodsList> shop = new List<GoodsList>();
            shop.Add(new GoodsList("MP3 Player", 15));
            shop.Add(new GoodsList("Baseball Cards", 3));
            shop.Add(new GoodsList("Board Games", 7));
            shop.Add(new GoodsList("Alien Relics", 9));
            shop.Add(new GoodsList("Iron", 10));
            shop.Add(new GoodsList("Platinum", 55));
            foreach (var value in shop)
            {
                Console.WriteLine(value);
            }
        }
    }

        
}
