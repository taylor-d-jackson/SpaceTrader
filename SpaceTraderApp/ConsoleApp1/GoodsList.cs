using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class GoodsList
    {

        //Creates the Goodslist class which defines the Name, Cost, and Capacity for each Planet's shop.

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

    }

    

}
