using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello first C# console app");




            //SayHello();
            //PrintArgs(args);
            //PrintArgsAsJoinedStringList(args);
            DataTypes();


            Console.ReadLine();
            
        }


        private static void DataTypes()
        {
            Console.WriteLine("\nDataTypes >>");
            bool canIVote = true;
            Console.WriteLine("Biggest integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest integer : {0}", int.MinValue);
            Console.WriteLine("Biggest long : {0}", long.MaxValue);
            Console.WriteLine("Smallest long : {0}", long.MinValue);

            decimal decPiVal = 3.1456231564465432165413165131651321543215M;
            decimal decBigNum = 3.000054M;
            Console.WriteLine("DEC : Pi + Bignum = {0}", decPiVal + decBigNum);
            Console.WriteLine("Biggest decimal : {0}", decimal.MaxValue);
            Console.WriteLine("Smallest decimal : {0}", decimal.MinValue);

            double doublePiVal = 3.14562315644654;
            double doubleBigNum = 3.000054;
            Console.WriteLine("double : Pi + Bignum = {0}", doublePiVal + doubleBigNum);
            Console.WriteLine("Biggest double : {0}", double.MaxValue.ToString("#"));
            Console.WriteLine("Smallest double : {0}", double.MinValue.ToString("#"));


            float floatPiVal = 3.14562354F;
            float floatBigNum = 3.000054F;
            Console.WriteLine("float : Pi + Bignum = {0}", floatPiVal + floatBigNum);
            Console.WriteLine("Biggest float : {0}", float.MaxValue.ToString("#"));
            Console.WriteLine("Smallest float : {0}", float.MinValue.ToString("#"));

            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("5");
            Console.WriteLine("boolFromStr : {0}", boolFromStr);

            DateTime awesomeDate = new DateTime(1977, 6, 8);
            Console.WriteLine("Day of week {0}", awesomeDate.DayOfWeek);
            awesomeDate = awesomeDate.AddDays(4);
            Console.WriteLine("New date {0}", awesomeDate.Date);

            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 25, 0));
            Console.WriteLine("New TimeSpan : {0}", lunchTime);

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
