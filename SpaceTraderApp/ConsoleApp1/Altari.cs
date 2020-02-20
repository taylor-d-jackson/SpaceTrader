using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Altari
    {
        string Name = "Altari";
        string Location;
        string Description;
        int XCoord = 4;
        int YCoord = 20;

        public Altari()
        {

        }



        public Altari(string name, string location, string description, int xco, int yco)
        {
            this.Name = name;
            this.Location = location;
            this.Description = description;
            this.XCoord = xco;
            this.YCoord = yco;

        }

        public void AltariGoods()
        {
            List<GoodsList> shop = new List<GoodsList>();
            shop.Add(new GoodsList("Nickel", 20, 1));
            shop.Add(new GoodsList("Medical Supply Bag", 20, 1));
            shop.Add(new GoodsList("Water Pack", 22, 1));
            shop.Add(new GoodsList("Radio Communicator", 26, 1));
            shop.Add(new GoodsList("Nitrogen", 28, 1));
            shop.Add(new GoodsList("Solar Panels", 67, 1));
        }
    }
}
