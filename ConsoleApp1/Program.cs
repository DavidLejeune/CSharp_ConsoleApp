using System;
using System.Collections;
using System.Numerics;

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
            //DataTypes();
            OutputFormatting();
            PlayWithStrings();



            Console.ReadLine();

        }

        private static void PlayWithStrings()
        {
            Console.WriteLine("\nPlayWithStrings");
            string randString = "This is a string";
            Console.WriteLine("String length : {0}", randString.Length);
            Console.WriteLine("String contains word is : {0}", randString.Contains("is"));
            Console.WriteLine("Index of is  : {0}", randString.IndexOf("is"));
            Console.WriteLine("Remove string : {0}", randString.Remove(0,6));
            Console.WriteLine("Insert string : {0}", randString.Insert(10, "short "));
            Console.WriteLine("Replace String : {0}", randString.Replace("string", "sentence"));
            Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Compare A to a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Add left : {0}", randString.PadLeft(20, '.'));
            Console.WriteLine("Add right : {0}", randString.PadLeft(20, '-'));
            Console.WriteLine("Trim white space : {0}", randString.Trim());
            Console.WriteLine("Uppercase : {0}", randString.ToUpper());
            Console.WriteLine("Lowercase : {0}", randString.ToLower());
            string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");
            Console.Write(newString + "\n");
        }


        private static void OutputFormatting()
        {
            Console.WriteLine("\nOutputFormatting");
            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("Pad with 0s : {0:d4}", 23);
            Console.WriteLine("3 Decimals : {0:f3}", 23.45555);
            Console.WriteLine("Commas and decimals : {0:n4}", 2300);
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

            Console.WriteLine("BIG INTEGERS");
            BigInteger bigNum = BigInteger.Parse("12345");
            Console.WriteLine("Big Numbers * 2 = {0}", bigNum * 2);
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
