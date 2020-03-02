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
            var cantina = new TravelDialogue();
            int item1 = 0;
            int quan = 0;
            var randEvent = new PositiveEvent();
            var dynMap = new Map();
            
            

            do
            {
                
                do
                {
                    staticMenu.App(gameData);
                    Console.WriteLine($"What would you like to do: 1.) Travel to a New Planet 2.) Head to the Cantina 3.) Head to the Marketplace 4.) View Map 5.) View Inventory");
                    
                    var menuSelection = Console.ReadKey().KeyChar;
                    if (menuSelection == '1')
                    {


                            Console.Clear();
                            
                            staticMenu.App(gameData);
                            
                            newEvent.Storyline(gameData);
                            
                            Console.WriteLine("\nPress enter to continue");

                            Console.ReadLine();

                            Console.Clear();



                        break;

                        
                        
                    }
                    if (menuSelection == '2')
                    {
                        
                        Console.Clear();
                        staticMenu.App(gameData);
                        cantina.Cantina(gameData);
                        Console.ReadLine();
                        Console.Clear();
                        
                        break;
                    }
                    if (menuSelection == '3')
                    {
                        ConsoleKeyInfo cki;

                        

                        do
                        {
                            Console.Clear();
                            
                            staticMenu.App(gameData);
                            
                            newEvent.Marketplace(gameData);
                            //Console.WriteLine("\n\nPress the Escape (Esc) key to return to the previous menu: \n");
                            //cki = Console.ReadKey();
                            Console.Clear();
                            break;

                        } while (cki.Key != ConsoleKey.Escape);
                        
                        
                        
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

                    if (menuSelection == '5')
                    {
                        ConsoleKeyInfo cki;

                        do
                        {
                            Console.Clear();
                            staticMenu.App(gameData);
                            newEvent.Inventory(gameData);
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
