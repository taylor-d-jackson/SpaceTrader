using System.Collections.Generic;

namespace ConsoleApp1
{
    public class GameData
    {

        //Defines the GameData class which sets the values passed to a number of methods to update information on your static menu.

        public int Currency = 1000;
        public int Age = 18;
        public int CurrentCapacity = 0;
        public int TotalShipCapacity = 10000;
        public string ShipLocation = "Earth";
        public int TravelCounter = 1;
        public List<GoodsList> Inventory = new List<GoodsList>();
        

        public GameData()
        {}

        public GameData(int currency, int age, int currentCapacity, int totalShipCapacity, string shipLocation, int travelCounter, List<GoodsList> inventory)
        {
            this.Currency = currency;
            this.Age = age;
            this.CurrentCapacity = currentCapacity;
            this.TotalShipCapacity = totalShipCapacity;
            this.ShipLocation = shipLocation;
            this.TravelCounter = travelCounter;
            this.Inventory = inventory;
            
        }
    }
}