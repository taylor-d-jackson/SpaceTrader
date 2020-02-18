using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Planet
    {
        string Name;
        string Description;
        int XCoord;
        int YCoord;
        
        public Planet()
        {

        }

        public Planet(string name, string description, int xco, int yco)
        {
            this.Name = name;
            this.Description = description;
            this.XCoord = xco;
            this.YCoord = yco;
        }
    }
}
