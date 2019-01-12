using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello first C# console app");




            SayHello();
            PrintArgs(args);
            PrintArgsAsJoinedStringList(args);

            Console.ReadLine();
            
        }

        private static void PrintArgs(string[] args)
        {
            Console.WriteLine("\nPrintArgs >> ");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg {0} : {1} ", i, args[i]);
            }

        }


        private static void PrintArgsAsJoinedStringList(string[] args)
        {
            Console.WriteLine("\nPrintArgsAsJoinedStringList >>");
            string[] myArgs = Environment.GetCommandLineArgs();
            Console.WriteLine(string.Join(", ", myArgs));

        }


        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0} ", name);
        }
        
    } 
}
