using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class TravelDialogue
    {
        
        
        string earth = "Earth";
        string voliv = "Voliv";
        string zadesta = "Zadesta";
        string altari = "Altari";
        string alphaCentauri = "Alpha Centauri";
        Planet planet;
        

        public GameData Marketplace(GameData gameData)
        {

            //Creates our 5 planets and defines the goods available for trade at each planet.
            
            
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
            
            //Series of IF statements that will run the Buy/Sell Method to purchase/sell goods depending on where you are located.

            if (gameData.ShipLocation == earth)
            {
                planet = planetEarth;
                BuySell(planet, gameData);
                
            }
            
            if (gameData.ShipLocation == voliv)
            {
                planet = planetVoliv;
                BuySell(planet, gameData);
            }
            
            if (gameData.ShipLocation == alphaCentauri)
            {
                planet = planetAlphaCentauri;
                BuySell(planet, gameData);
            }
            
            if (gameData.ShipLocation == zadesta)
            {
                planet = planetZadesta;
                BuySell(planet, gameData);
            }
            
            if (gameData.ShipLocation == altari)
            {
                planet = planetAltari;
                BuySell(planet, gameData);
            }

            
            


            return gameData;
        }

        public GameData Inventory(GameData gameData)

            //Method that lists your current inventory

        {

            for (int i = 0; i < gameData.Inventory.Count; i++)
            {
                Console.WriteLine($"{i}. {gameData.Inventory[i]}");
            }
            return gameData;
        }

        public GameData BuySell(Planet planet, GameData gameData)
        {
            
            //Method that gives you the option to buy or sell from a menu.
            //Based on the users selection will list the goods available to purchase or list your goods available to sell.
            //Updates player currency
            //Updates Cargo capacity
            
            bool exit = false;
            

            do
            {
                Console.WriteLine("To purchase an item press: b\n" +
                                  "To sell an item press: s\n" +
                                  "To return to the previous menu press: x\n");

                var menuSelection = Console.ReadKey().KeyChar;
                if (menuSelection == 'b')

                //Buy code segment

                {
                    for (int i = 0; i < planet.shop.Count; i++)
                    {
                        Console.WriteLine($"{i}. {planet.shop[i]}");
                    }


                    Console.WriteLine("\nWhich item would you like to buy?");

                    int purchaseSelection = int.Parse(Console.ReadLine());

                    Console.WriteLine($"How many {planet.shop[purchaseSelection]}'s would you like to buy?");

                    int quantitySelection = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= quantitySelection; i++)
                    {
                        int newCurrency;
                        newCurrency = gameData.Currency - planet.shop[purchaseSelection].Cost;
                        gameData.Inventory.Add(planet.shop[purchaseSelection]);
                        gameData.Currency = newCurrency;
                        gameData.CurrentCapacity++;

                    }
                }

                //Sell Code Segment

                if (menuSelection == 's')
                {
                    for (int i = 0; i < gameData.Inventory.Count; i++)
                    {
                        Console.WriteLine($"{i}. {gameData.Inventory[i]}");
                    }

                    Console.WriteLine("\nWhich item would you like to sell?");

                    int saleSelection = int.Parse(Console.ReadLine());

                    
                        int newCurrency;
                        newCurrency = gameData.Currency + gameData.Inventory[saleSelection].Cost;
                        gameData.Inventory.Remove(gameData.Inventory[saleSelection]);
                        gameData.Currency = newCurrency;
                        gameData.CurrentCapacity--;
                        Console.Clear();
                        
                    
                }
                if (menuSelection == 'x')
                {
                    exit = true;
                }


            } while (exit == false) ;



            //inventory.Add(allitems[index]);

            return (gameData);

        }

        public GameData Cantina(GameData gameData)
        {

            //Lists the Case for the Cantina method
            //Lists a Positive, NEgative, and Neutral player choice for each event.
            
            switch (gameData.TravelCounter)
            {
                case 1:
                    Console.WriteLine("An alien pack wants to know more about Earth's atmosphere and will pay you for a guided tour.");
                    Console.WriteLine("\nWhat would you like to do? \n1.) Agree to the tour request. \n2.) Tell the leader you want a tour of Zadesta first \n3.) Reject the tour request.");

                    var menuSelection = Console.ReadKey().KeyChar;

                    
                    
                    if (menuSelection == '1')
                    {
                        Console.Clear();
                        Console.WriteLine("You have received 100 Spacebucks from the Alien pack leader for his gratitude.");
                        var newCurrency = gameData.Currency + 100;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection == '2')
                    {
                        Console.WriteLine("You have offended the Alien pack leader and paid them 58 Spacebucks in order to calm them down.");
                        var newCurrency = gameData.Currency - 58;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection == '3')
                    {
                        Console.WriteLine("You reject the tour request and the aliens go on their way.");
                    }
                    break;

                case 2:
                    Console.WriteLine("A rogue general has asked you to deliver a package to Altari.  You cannot open it prior to delivery.");
                    Console.WriteLine("\nWhat would you like to do? \n1.) Agree to deliver the package. \n2.) Agree to deliver the package but open it first to ensure it's safe. \n3.) Reject to deliver the package.");

                    var menuSelection1 = Console.ReadKey().KeyChar;



                    if (menuSelection1 == '1')
                    {
                        Console.WriteLine("You have received 245 Spacebucks from the general to deliver the package.");
                        var newCurrency = gameData.Currency + 245;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection1 == '2')
                    {
                        Console.WriteLine("An alarm sounds and the package self destructs causing damage to your ship. You pay 299 spacebucks to repair the damage.");
                        var newCurrency = gameData.Currency - 299;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection1 == '3')
                    {
                        Console.WriteLine("You refuse to deliver the package.");
                    }

                    break;

                case 3:
                    Console.WriteLine($"You've landed on {gameData.ShipLocation}. A gang of space pirates threaten to take your ship. ");
                    Console.WriteLine("\nWhat would you like to do? \n1.) Try to talk your way out of the situation.(risking death). \n2.) Try to pay them off. \n3.) Try to run.");

                    var menuSelection2 = Console.ReadKey().KeyChar;



                    if (menuSelection2 == '1')
                    {
                        Console.WriteLine("Through some tense moments you end up connecting with the gang leader. The gang doesn't kill you and even leave you with a small amount of money for your travels.");
                        var newCurrency = gameData.Currency + 115;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection2 == '2')
                    {
                        Console.WriteLine("Tensions grow but the gang begrudgingly allows you to live for a small fee of 110 spacebucks.");
                        var newCurrency = gameData.Currency - 110;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection2 == '3')
                    {
                        Console.WriteLine("You are able to outrun the gang and lose them in an asteroid field.");
                    }

                    break;

                case 4:
                    Console.WriteLine($"You've landed on {gameData.ShipLocation}. You discover a crashed spaceship. ");
                    Console.WriteLine("\nWhat would you like to do? \n1.) Do not go inside. \n2.) Go inside and see if you can salvage anything. \n3.) Enter the ship to see if anyone needs medical attention.");

                    var menuSelection3 = Console.ReadKey().KeyChar;



                    if (menuSelection3 == '1')
                    {
                        Console.WriteLine("You leave the ship alone and head back to what you were doing. You find 20 spacebucks on the way back to your ship.");
                        var newCurrency = gameData.Currency + 20;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection3 == '2')
                    {
                        Console.WriteLine("You enter the ship. A core reactor explodes and you are lucky to escape with your life. You had to pay 125 spacebucks for medical treatment.");
                        var newCurrency = gameData.Currency - 125;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection3 == '3')
                    {
                        Console.WriteLine("You enter the ship but don't find anyone on board so you leave the ship.");
                    }

                    break;

                case 5:
                    Console.WriteLine($"You've been invited to a party by a rich citizen on {gameData.ShipLocation}.");
                    Console.WriteLine("\nWhat would you like to do? \n1.) Head to the party with gifts for your host.. \n2.) Refuse the party invitation. \n3.) Offer to DJ the party.");

                    var menuSelection4 = Console.ReadKey().KeyChar;



                    if (menuSelection4 == '1')
                    {
                        Console.WriteLine("You head to the party. Your host is so thankful for his small gift that he gifts you a rare artifact worth 400 spacebucks.");
                        var newCurrency = gameData.Currency + 400;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection4 == '2')
                    {
                        Console.WriteLine("You refuse the party invitation. Your host is offended and hires a gang of ruffians to beat you up. They steal the money you had on you.");
                        var newCurrency = gameData.Currency - 45;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection4 == '3')
                    {
                        Console.WriteLine($"You DJ the party. It is underwhelmning and the guests are not impressed. Your dreams of being a DJ die on {gameData.ShipLocation}.");
                    }
                    break;

                case 6:
                    Console.WriteLine($"You've landed on {gameData.ShipLocation} but your ship is stuck in space rubble.");
                    Console.WriteLine("\nWhat would you like to do? \n1.) Accept help from a shifty looking space port mechanic. \n2.) Leave the ship now and come back with more help. \n3.) Attempt to blow your way out of the rubble.");

                    var menuSelection5 = Console.ReadKey().KeyChar;



                    if (menuSelection5 == '1')
                    {
                        Console.WriteLine("\"Shifty\" helps remove your ship from the rubble. You play a round of poker afterwards and win 85 spacebucks from him.");
                        var newCurrency = gameData.Currency + 85;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection5 == '2')
                    {
                        Console.WriteLine("You leave the ship to look for help. When you come back you notice some of your supplies are missing. You lose 163 spacebucks.");
                        var newCurrency = gameData.Currency - 163;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection5 == '3')
                    {
                        Console.WriteLine($"You successfully blow your ship out of the rubble on {gameData.ShipLocation}.");
                    }
                    break;

                case 7:
                    Console.WriteLine($"A king on {gameData.ShipLocation} offers you spacebucks in exchange for jokes from Earth.");
                    Console.WriteLine("\nWhat would you like to do? \n1.) Tell him jokes from Louis C.K. \n2.) Tell him jokes from Dane Cook. \n3.) Tell him jokes from Bill Burr.");

                    var menuSelection6 = Console.ReadKey().KeyChar;



                    if (menuSelection6 == '1')
                    {
                        Console.WriteLine("The king laughs so much that he blows his drink out of his 7 nostrils. He pays you 130 Spacebucks.");
                        var newCurrency = gameData.Currency + 130;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection6 == '2')
                    {
                        Console.WriteLine("The king has heard these jokes before. He charges you for his time. Now you're out 100 Spacebucks over some jokes.");
                        var newCurrency = gameData.Currency - 100;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection6 == '3')
                    {
                        Console.WriteLine($"The king laughs but says that he's heard better.");
                    }
                    break;

                case 8:
                    Console.WriteLine($"A warrior on {gameData.ShipLocation} offers to train you for a small amount of money.");
                    Console.WriteLine("\nWhat would you like to do? \n1.) Have the warrior train you with weapons. \n2.) Have the warrior teach you the Killer Alien Death Strike. \n3.) Have them teach you defensive moves.");

                    var menuSelection7 = Console.ReadKey().KeyChar;



                    if (menuSelection7 == '1')
                    {
                        Console.WriteLine("The warrior trains you with weapons. He is so impressed with your progress that he gives you an Altarian blade worth 235 spacebucks.");
                        var newCurrency = gameData.Currency + 235;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection7 == '2')
                    {
                        Console.WriteLine("The warrior almost kills you demonstrating the Killer ALien Death Strike. Your medical bills are 332 spacebucks.");
                        var newCurrency = gameData.Currency - 332;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection7 == '3')
                    {
                        Console.WriteLine($"You have a better understaning of how to defend yourself.");
                    }
                    break;

                case 9:
                    Console.WriteLine($"Police on {gameData.ShipLocation} stop you to ask about illegal activity.");
                    Console.WriteLine("\nWhat would you like to do? \n1.) Show the police you are not carrying anything illegal. \n2.) Dump your contraband. \n3.) Offer the police a \"gift\".");

                    var menuSelection8 = Console.ReadKey().KeyChar;



                    if (menuSelection8 == '1')
                    {
                        Console.WriteLine("After their inspection the police refer you to a merchant you cuts you a good deal. You earn 239 Spacebucks from the deal.");
                        var newCurrency = gameData.Currency + 239;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection8 == '2')
                    {
                        Console.WriteLine("You attempt to dump your contraband but the police catch you and fine you 255 Spacebucks.");
                        var newCurrency = gameData.Currency - 255;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection8 == '3')
                    {
                        Console.WriteLine($"You offer the police a gift. They laugh and wave you on.");
                    }
                    break;

                case 10:
                    Console.WriteLine($"Your ship needs repairs.");
                    Console.WriteLine("\nWhat would you like to do? \n1.) Attempt to fix the problem yourself. \n2.) Trade for a new ship. \n3.) Hire a repair service.");

                    var menuSelection9 = Console.ReadKey().KeyChar;



                    if (menuSelection9 == '1')
                    {
                        Console.WriteLine("You buy a used modulator. Stuffed in documentation is a small amount of money. Your ship is repaired and you earn 175 Spacebucks.");
                        var newCurrency = gameData.Currency + 175;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection9 == '2')
                    {
                        Console.WriteLine("You trade in your old ship for a newer model. It's a lemon and you have to pay to have the new one repaired. You're out 435 Spacebucks.");
                        var newCurrency = gameData.Currency - 435;
                        gameData.Currency = newCurrency;
                    }
                    if (menuSelection9 == '3')
                    {
                        Console.WriteLine($"You hire a repair service. They forget to bill you and you go on your way.");
                    }
                    break;





                default:
                    break;
            }
            
            return gameData;
        }

        

        public GameData Storyline(GameData gameData)
        {

            //Storyline method which prints a short story based on which planet you have traveled to.

            var staticMenu = new StaticMenu();
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


            Console.Clear();

            Console.WriteLine($"Where would you like to travel: {earth} || {alphaCentauri} || {altari} || {zadesta} || {voliv} ");

            gameData.ShipLocation = Console.ReadLine();

            Console.Clear();

            switch (travelCounter)
            {
                case 1:

                    staticMenu.App(gameData);
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