using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Warrior
    {
        // Define the Warriors properties
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttkMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // Constructor initializes the warrior
        public Warrior(string name = "Warrior",
            double health = 0,
            double attkMax = 0,
            double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }



    }
}
