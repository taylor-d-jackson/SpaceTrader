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

                randEvent.Event(item1, quan, gameData);
                staticMenu.App(gameData);
                
                newEvent.Storyline(gameData);
                dynMap.DynamicMap(gameData);
                
            } while (gameData.Age < 65);

            staticMenu.App(gameData);








        }
    }
}
