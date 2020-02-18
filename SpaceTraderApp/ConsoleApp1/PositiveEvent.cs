using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PositiveEvent
    {
        public int ItemSelection = 0;
        public int Quantity = 0;

    public PositiveEvent()
        {

        }
        
        
        public (int, int, GameData) Event(int item1, int quan, GameData gameData)
        {

            
            

            var prng = new Random();
            item1 = prng.Next(1, 30);
            quan = prng.Next(15, 100);
            this.ItemSelection = item1;
            this.Quantity = quan;
            gameData.Currency = gameData.Currency + prng.Next(1, 150);
            return (item1, quan, gameData);

        }

       

        
    }
    
}
