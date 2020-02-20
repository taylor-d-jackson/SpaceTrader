using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(160, 50);
            var gameData = new GameData();
            var staticMenu = new StaticMenu();
            var newEvent = new TravelDialogue();
            int item1 = 0;
            int quan = 0;
            var randEvent = new PositiveEvent();
            var dynMap = new Map();
            
            

            do
            {
                //TODO: Able to pass item value, a quantity value and update the static menu with changed spacebucks from the Event Class.
                //TODO: Incorporate random selection for item to associate with a good from our goods list and set the random value of quantity to give us that amount of that item.
                //TODO: Make NegativeEvent Class
                //TODO: Make Positive Event Class
                
                do
                {
                    staticMenu.App(gameData);
                    Console.WriteLine($"What would you like to do: 1.) Travel to a New Planet 2.) Head to the Cantina 3.) Head to the Marketplace 4.) View Map");
                    
                    var menuSelection = Console.ReadKey().KeyChar;
                    if (menuSelection == '1')
                    {
                        Console.Clear();
                        staticMenu.App(gameData);
                        newEvent.Storyline(gameData);
                        
                        
                        break;
                    }
                    if (menuSelection == '2')
                    {
                        //TODO: Add the Pos/Neg/Neut random event here.
                        staticMenu.App(gameData);
                        randEvent.Event(item1, quan, gameData);
                        
                        break;
                    }
                    if (menuSelection == '3')
                    {
                        ConsoleKeyInfo cki;

                        //TODO: Buy and Sell from inventory

                        do
                        {
                            Console.Clear();
                            
                            staticMenu.App(gameData);
                            Console.WriteLine("Here's what the marketplace has to offer: \n \n ");
                            newEvent.Marketplace(gameData);
                            Console.WriteLine("\n\nPress the Escape (Esc) key to return to the previous menu: \n");
                            cki = Console.ReadKey();
                            Console.Clear();
                            break;

                        } while (true);
                        
                        
                        
                    }
                    if (menuSelection == '4')
                    {
                        
                        ConsoleKeyInfo cki;

                        
                        do
                        {
                            
                            Console.Clear();
                            staticMenu.App(gameData);
                            dynMap.DynamicMap(gameData);
                            Console.WriteLine("\n\nPress the Escape (Esc) key to return to the previous menu: \n");
                            cki = Console.ReadKey();
                            Console.Clear();
                            break;

                        } while (cki.Key != ConsoleKey.Escape);

                    }
                } while (true);
                
                
                
                
                
                
            } while (gameData.Age < 65);

            staticMenu.App(gameData);








        }
    }
}
