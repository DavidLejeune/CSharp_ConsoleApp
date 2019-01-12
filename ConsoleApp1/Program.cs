using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello first C# console app");

            Console.WriteLine("These are the args : ");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg {0} : {1} ", i , args[i]);
            }
            Console.ReadLine();
        }
    } 
}
