using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AlphaCentauri
    {
        string Name = "Alpha Centauri";
        string Location;
        string Description;
        int XCoord = 15;
        int YCoord = 9;

        public AlphaCentauri()
        {

        }



        public AlphaCentauri(string name, string location, string description, int xco, int yco)
        {
            this.Name = name;
            this.Location = location;
            this.Description = description;
            this.XCoord = xco;
            this.YCoord = yco;
        }

        public void AlphaCentauriGoods()
        {
            List<GoodsList> shop = new List<GoodsList>();
            shop.Add(new GoodsList("Food Crate", 10, 1));
            shop.Add(new GoodsList("MoonBrew", 11, 1));
            shop.Add(new GoodsList("Oxygen Cells", 15, 1));
            shop.Add(new GoodsList("Tools", 18, 1));
            shop.Add(new GoodsList("Space Narcotics", 19, 1));
            shop.Add(new GoodsList("Iridium", 64, 1));
        }
    }
}
