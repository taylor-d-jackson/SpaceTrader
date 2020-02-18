using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TravelDialogue
    {
        bool Planet = true;
        



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
            var classEarth = new Earth();
            var classAltari = new Altari();
            var classAlphaCentauri = new AlphaCentauri();
            var classZadesta = new Zadesta();
            var classVoliv = new Voliv();


            //TODO: Call and print the shop list values for each planet.
            //TODO: Select a location to travel from a scrolling list model. Use task tracker as a model.

            Console.WriteLine($"Where would you like to travel: {earth} || {alphaCentauri} || {altari} || {zadesta} || {voliv} ");
            gameData.ShipLocation = Console.ReadLine();
            Console.Clear();
            var activePlanet = gameData.ShipLocation;
            
            

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

                        break;

            }
            return gameData;
        }
    }
}