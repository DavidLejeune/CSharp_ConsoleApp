using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Battle
    {

        // This is a utility class so it makes sense
        // to have just static methods

        // Recieve both Warrior objects
        public static void StartFight(Warrior warrior1,
            Warrior warrior2)
        {
            // Loop giving each Warrior a chance to attack
            // and block each turn until 1 dies
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

    }
}