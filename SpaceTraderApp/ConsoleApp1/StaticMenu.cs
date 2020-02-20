using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StaticMenu
    {
        public void App(GameData gameData)
        {
            
            int age = gameData.Age;
            int currentCapacity = gameData.CurrentCapacity;
            int totalShipCapacity = gameData.TotalShipCapacity;
            string shipLocation = gameData.ShipLocation;
            int travelCounter = gameData.TravelCounter;
            

            

            Console.WriteLine("================================================================================================================================================================");
            Console.WriteLine($"                                      SpaceBucks: {gameData.Currency} || Age: {age} || Cargo Capacity: {currentCapacity} // {totalShipCapacity} || Current Location: {shipLocation}                             ");
            Console.WriteLine("================================================================================================================================================================");
            Console.WriteLine("\n"+"\n");
            
        }
    }
}
