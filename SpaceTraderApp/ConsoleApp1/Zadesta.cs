using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Zadesta
    {
        string Name = "Zadesta";
        string Location;
        string Description;
        int XCoord = 30;
        int YCoord = 15;

        public Zadesta()
        {

        }





        public Zadesta(string name, string location, string description, int xco, int yco)
        {
            this.Name = name;
            this.Location = location;
            this.Description = description;
            this.XCoord = xco;
            this.YCoord = yco;
        }

        public void ZadestaGoods()
        {
            List<GoodsList> shop = new List<GoodsList>();
            shop.Add(new GoodsList("Weapons", 30));
            shop.Add(new GoodsList("Silver", 33));
            shop.Add(new GoodsList("Explosives", 35));
            shop.Add(new GoodsList("Gold", 47));
            shop.Add(new GoodsList("Anti-Matter Cells", 49));
            shop.Add(new GoodsList("Capacitors", 53));
        }
    }
}
