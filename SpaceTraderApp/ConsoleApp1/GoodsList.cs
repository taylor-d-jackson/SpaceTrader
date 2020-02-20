using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class GoodsList
    {
        string Name;
        int Cost;
        int Capacity;
        


        
        public GoodsList(string name, int cost, int capacity)
        {
            this.Name = name;
            this.Cost = cost;
            this.Capacity = capacity;
        }

        public override string ToString()
        {
            return $"{Cost} - {Name}";
        }



        //List<GoodsList> shop = new List<GoodsList>();
        //shop.Add(new GoodsList("BioFuel", 72);
        //shop.Add(new GoodsList("FrogArmor", 1009992);

        //class Character
        //{
        //    List<GoodsList> Inventory;
        //}

    }

    

}
