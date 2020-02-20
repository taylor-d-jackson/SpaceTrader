using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TravelDialogue
    {
        bool Planet = true;
        string earth = "Earth";
        string voliv = "Voliv";
        string zadesta = "Zadesta";
        string altari = "Altari";
        string alphaCentauri = "Alpha Centauri";

        

        public GameData Marketplace(GameData gameData)
        {
            var planetEarth = new Planet
            {
                Name = "Earth",
                Description = "",
                XCoord = 3,
                YCoord = 1,
                shop = new List<GoodsList>
                {
                    new GoodsList("MP3 Player", 15, 1),
                    new GoodsList("Baseball Cards", 3, 1),
                    new GoodsList("Board Games", 7, 1),
                    new GoodsList("Alien Relics", 9, 1),
                    new GoodsList("Iron", 10, 1),
                    new GoodsList("Platinum", 55, 1)
                }


            };



            var planetAltari = new Planet
            {
                Name = "Altari",
                Description = "",
                XCoord = 4,
                YCoord = 20,
                shop = new List<GoodsList>
                {
                    new GoodsList("Nickel", 20, 1),
                    new GoodsList("Medical Supply Bag", 20, 1),
                    new GoodsList("Water Pack", 22, 1),
                    new GoodsList("Radio Communicator", 26, 1),
                    new GoodsList("Nitrogen", 28, 1),
                    new GoodsList("Solar Panels", 67, 1),
                }
            };

            var planetAlphaCentauri = new Planet
            {
                Name = "Alpha Centauri",
                Description = "",
                XCoord = 4,
                YCoord = 20,
                shop = new List<GoodsList>
                {
                    new GoodsList("Food Crate", 10, 1),
                    new GoodsList("MoonBrew", 11, 1),
                    new GoodsList("Oxygen Cells", 15, 1),
                    new GoodsList("Tools", 18, 1),
                    new GoodsList("Space Narcotics", 19, 1),
                    new GoodsList("Iridium", 64, 1),
                }
            };

            var planetZadesta = new Planet
            {
                Name = "Zadesta",
                Description = "",
                XCoord = 30,
                YCoord = 15,
                shop = new List<GoodsList>
                {
                    new GoodsList("Weapons", 30, 1),
                    new GoodsList("Silver", 33, 1),
                    new GoodsList("Explosives", 35, 1),
                    new GoodsList("Gold", 47, 1),
                    new GoodsList("Anti-Matter Cells", 49, 1),
                    new GoodsList("Capacitors", 53, 1),
                }
            };
            var planetVoliv = new Planet
            {
                Name = "Voliv",
                Description = "",
                XCoord = 4,
                YCoord = 20,
                shop = new List<GoodsList>
                {
                    new GoodsList("Biofuel", 72, 1),
                    new GoodsList("Osmium", 78, 1),
                    new GoodsList("Ship Core Reactor", 80, 1),
                    new GoodsList("Rubidium", 89, 1),
                    new GoodsList("Samarium", 92, 1),
                    new GoodsList("Lutetium", 100, 1),
                }

            };
            if (gameData.ShipLocation == earth)
            {
                foreach (var printString in planetEarth.shop) { Console.WriteLine(printString.ToString()); }

            }
            if (gameData.ShipLocation == voliv)
            {
                foreach (var printString in planetVoliv.shop) { Console.WriteLine(printString.ToString()); }
            }
            if (gameData.ShipLocation == alphaCentauri)
            {
                foreach (var printString in planetAlphaCentauri.shop) { Console.WriteLine(printString.ToString()); }
            }
            if (gameData.ShipLocation == zadesta)
            {
                foreach (var printString in planetZadesta.shop) { Console.WriteLine(printString.ToString()); }
            }
            if (gameData.ShipLocation == altari)
            {
                foreach (var printString in planetAltari.shop) { Console.WriteLine(printString.ToString()); }
            }

            Console.WriteLine("Which item would you like to buy?");


            return gameData;
        }

        public GameData Cantina(GameData gameData)
        {
            return gameData;
        }

        public GameData Travel(GameData gameData)
        {
            return gameData;
        }

        public GameData Storyline(GameData gameData)
        {

            
            double currency = gameData.Currency;
            int age = gameData.Age;
            int currentCapacity = gameData.CurrentCapacity;
            int totalShipCapacity = gameData.TotalShipCapacity;
            string shipLocation = gameData.ShipLocation;
            int travelCounter = gameData.TravelCounter;
            string earth = "Earth";
            string alphaCentauri = "Alpha Centauri";
            string altari = "Altari";
            string zadesta = "Zadesta";
            string voliv = "Voliv";




            //TODO: Call and print the shop list values for each planet.
            //TODO: Select a location to travel from a scrolling list model. Use task tracker as a model.



            Console.Clear();
            Console.WriteLine($"Where would you like to travel: {earth} || {alphaCentauri} || {altari} || {zadesta} || {voliv} ");
            gameData.ShipLocation = Console.ReadLine();
            Console.Clear();

            switch (travelCounter)
            {
                case 1:
                    Console.WriteLine($"You've arrived on {gameData.ShipLocation} after a long journey. After securing your spaceship you head to the marketplace to see what they have to offer.");

                    gameData.TravelCounter++;
                    gameData.Age = gameData.Age + 4;
                    
                   

                    break;
                case 2:
                    Console.WriteLine($"Having landed on {gameData.ShipLocation} after a long journey, you head to the local cantina to grab a drink and to try to gather information on good deals.\n " +
                            $"You finish your drink and head to the marketplace to hopefully make a quick Spacebuck");
                    gameData.TravelCounter++;
                    gameData.Age = gameData.Age + 4;

                    

                    break;
                case 3:
                    Console.WriteLine($"{gameData.ShipLocation} looks especially dreary today as you land your ship at the spaceport. You're hoping for better fortune and brighter opportunities at the marketplace");
                    gameData.TravelCounter++;
                    gameData.Age = gameData.Age + 4;

                    

                    break;
                case 4:
                    Console.WriteLine($"Your adrenaline is still pumping as you navigate your ship to safely land at docking port 5 on {gameData.ShipLocation}. That asteroid field was nowhere on your space charts. \n" +
                            $"You're feeling alive and ready to do some trading.");
                    gameData.TravelCounter++;
                    gameData.Age = gameData.Age + 4;

                    

                    break;
                case 5:
                    Console.WriteLine($"Having landed on {gameData.ShipLocation} you already want to move on. You make a quick stop at the market to trade before you get off this rock.");
                    gameData.TravelCounter++;
                    gameData.Age = gameData.Age + 4;

                    

                    break;
                case 6:
                    Console.WriteLine($"Today is the galactic New Year. Citizens of {gameData.ShipLocation} are celebrating in the streets. Energy is high and you're hoping the merchants are feeling \n" +
                            $"especially generous today as you head to the marketplace");
                    gameData.TravelCounter++;
                    gameData.Age = gameData.Age + 4;

                    

                    break;
                case 7:
                    Console.WriteLine($"As you head to {gameData.ShipLocation}'s marketplace you pass a crowd of people. They seem upset. You hope this doesn't effect the market.");
                    gameData.TravelCounter++;
                    gameData.Age = gameData.Age + 4;

                    
                    break;
                case 8:
                    Console.WriteLine($"What a smooth landing. You're feeling optimistic about the prices on {gameData.ShipLocation} today.");
                    gameData.TravelCounter++;
                    gameData.Age = gameData.Age + 4;

                    
                    break;
                case 9:
                    Console.WriteLine($"You picked up some radio chatter as you pulled into {gameData.ShipLocation}'s spaceport. The local traders seem to be unsure of the market today.\n" +
                            $"Hopefully their worry is unfounded.");
                    gameData.TravelCounter++;
                    gameData.Age = gameData.Age + 4;

                    
                    break;
                case 10:
                    Console.WriteLine($"What a fool, That mining rig almost took you out! With you and your goods still in one piece you head to {gameData.ShipLocation}'s marketplace");
                    gameData.TravelCounter++;
                    gameData.Age = gameData.Age + 4;

                    


                    break;
                case 11:
                    Console.WriteLine($"What a beautiful day to do some trading on {gameData.ShipLocation}!");
                    gameData.TravelCounter++;
                    gameData.Age = gameData.Age + 4;

                    
                    break;
                default:
                    Console.WriteLine($"You're on {gameData.ShipLocation}");
                    gameData.TravelCounter++;
                    gameData.Age = gameData.Age + 4;

                    if (gameData.ShipLocation == earth)
                    {
                        Console.WriteLine("Test");
                    }
                    if (gameData.ShipLocation == voliv)
                    {
                        Console.WriteLine("Test");
                    }
                    if (gameData.ShipLocation == alphaCentauri)
                    {
                        Console.WriteLine("Test");
                    }
                    if (gameData.ShipLocation == zadesta)
                    {
                        Console.WriteLine("Test");
                    }
                    if (gameData.ShipLocation == altari)
                    {
                        Console.WriteLine("Test");
                    }

                    break;

            }
            return gameData;
        }
    }
}