using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class GoodsList
    {
        string Name;
        public int Cost;
        public int Capacity;
        


        
        public GoodsList(string name, int cost, int capacity)
        {
            this.Name = name;
            this.Cost = cost;
            this.Capacity = capacity;
        }

        public override string ToString()
        {
            return $"{Name} -- Cost: {Cost}\nCapacity: {Capacity}\n";
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
