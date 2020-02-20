using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Voliv
    {
        string Name = "Voliv";
        string Location;
        string Description;
        int XCoord = 45;
        int YCoord = 24;

        public Voliv()
        {

        }




        public Voliv(string name, string location, string description, int xco, int yco)
        {
            this.Name = name;
            this.Location = location;
            this.Description = description;
            this.XCoord = xco;
            this.YCoord = yco;
        }

        public void VolivGoods()
        {
            List<GoodsList> shop = new List<GoodsList>();
            shop.Add(new GoodsList("Biofuel", 72, 1));
            shop.Add(new GoodsList("Osmium", 78, 1));
            shop.Add(new GoodsList("Ship Core Reactor", 80, 1));
            shop.Add(new GoodsList("Rubidium", 89, 1));
            shop.Add(new GoodsList("Samarium", 92, 1));
            shop.Add(new GoodsList("Lutetium", 100, 1));
        }
    }
}
