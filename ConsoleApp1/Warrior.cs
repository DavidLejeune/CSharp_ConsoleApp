﻿using System;
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

        // Always create a single Random instance and reuse
        // it or you will get the same value over and over
        Random rnd = new Random();

        // Generate a random atack value from 1
        // to the warriors maximum attack value
        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        // Generate a random block value from
        // 1 to the warriors maximum block
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }


    }
}
