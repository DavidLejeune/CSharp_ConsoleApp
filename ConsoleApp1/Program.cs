using System;
using System.Collections;
using System.Numerics;

// Needed for StringBuilder
using System.Text;
using System.Threading.Tasks;

// For culture specific formating
using System.Globalization;

// You use a namespace to define globally unique objects
namespace ConsoleApp1
{
    // A class defines the variables and methods used
    // by objects. I'll get more into this later
    class Program
    {
        // The main function is where execution begins
        // static functions belong to the class and 
        // can be executed without needing to create 
        // an object
        // void means that this function doesn't return
        // a value after it executes, but it is 
        // common to use int instead and return an 
        // integer value 0 : when successfully executed
        // or -1 when an error occurred
        // This function can receive multiple string
        // values that are saved into an array

        static void Main(string[] args)
        {

            // Write a string to the console followed
            // be a newline
            // Write() doesn't include a newline
            // The Console class provides functions for input
            // output and error streams for console applications
            Console.WriteLine("Hello World");

            // for loops allow you to cycle through information
            // We will get command line arguments passed and print
            // them

            for (int i = 0; i < args.Length; i++)
            {
                // We use format parameters to place the string
                // version of passed objects into the output
                Console.WriteLine("Arg {0} : {1}", i, args[i]);
            }

            // Passing command line arguments in Visual Studio
            // Right click on project name in Solution Explorer 
            // Select Properties
            // Select Debug tab on the left
            // Enter parameters in Command Line Arguments textbox
            // Click Start

            // Get an array of the command line arguments
            string[] myArgs = Environment.GetCommandLineArgs();

            // Use the Join function to combine arguments with a comma
            Console.WriteLine(string.Join(", ", myArgs));

            // Call for the function to execute
            // SayHello();

            // ---------- DATA TYPES ----------

            // Bools store true or false
            bool canIVote = true;

            // INTEGERS
            // Integers are 32-bit signed integers
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            // LONGS
            // Longs are 64-bit signed integers
            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            // DECIMALS
            // Decimals store 128-bit precise decimal values
            // It is accurate to 28 digits
            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

            Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);

            // DOUBLES
            // Doubles are 64-bit float types
            Console.WriteLine("Biggest Double : {0}", Double.MaxValue.ToString("#"));

            // It is precise to 14 digits
            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            // FLOATS
            // Floats are 32-bit float types
            Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));

            // It is precise to 6 digits
            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;
            Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);

            // Other Data Types
            // byte : 8-bit unsigned int 0 to 255
            // char : 16-bit unicode character
            // sbyte : 8-bit signed int 128 to 127
            // short : 16-bit signed int -32,768 to 32,767
            // uint : 32-bit unsigned int 0 to 4,294,967,295
            // ulong : 64-bit unsigned int 0 to 18,446,744,073,709,551,615
            // ushort : 16-bit unsigned int 0 to 65,535

            // You can convert from string to other types with Parse
            bool boolFromStr = bool.Parse("True");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");

            // ---------- DATETIME & TIMESPAN ----------

            // Used to define dates
            DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of Week : {0}", awesomeDate.DayOfWeek);

            // You can change values
            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);
            Console.WriteLine("New Date : {0}", awesomeDate.Date);

            // TimeSpan
            // Used to define a time
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);

            // Change values
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("New Time : {0}", lunchTime.ToString());

            // ---------- BIGINTEGER ----------
            // Used to store very large numbers
            // Select Project -> Add Reference
            // Select Assemblies -> System.Numerics.dll click Ok
            // Add this line using System.Numerics; at the top

            // Define the value using a text literal
            BigInteger bigNum = BigInteger.Parse("12345123451234512345");
            Console.WriteLine("Big Num * 2 = {0}", bigNum * 2);


            // ---------- FORMATTING OUTPUT ----------

            // Format output for currency
            Console.WriteLine("Currency : {0:c}", 23.455);

            // Pad with zeroes 
            Console.WriteLine("Pad with 0s : {0:d4}", 23);

            // Define decimals 
            Console.WriteLine("3 Decimals : {0:f3}", 23.4555);

            // Add commas and decimals
            Console.WriteLine("Commas : {0:n4}", 2300);

            // ---------- STRINGS ----------
            // Strings store a series of characters
            string randString = "This is a string";

            // Get number of characters in string
            Console.WriteLine("String Length : {0}", randString.Length);

            // Check if string contains other string
            Console.WriteLine("String Contains is : {0}",
                randString.Contains("is"));

            // Index of string match
            Console.WriteLine("Index of is : {0}",
                randString.IndexOf("is"));

            // Remove number of characters starting at an index
            Console.WriteLine("Remove string : {0}",
                randString.Remove(10, 6));

            // Add a string starting at an index
            Console.WriteLine("Insert String : {0}",
                randString.Insert(10, "short "));

            // Replace a string with another
            Console.WriteLine("Replace String : {0}",
                randString.Replace("string", "sentence"));

            // Compare strings and ignore case
            // < 0 : str1 preceeds str2
            // = : Zero
            // > 0 : str2 preceeds str1
            Console.WriteLine("Compare A to B : {0}",
                String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));

            // Check if strings are equal
            Console.WriteLine("A = a : {0}",
                String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

            // Add padding left
            Console.WriteLine("Pad Left : {0}",
                randString.PadLeft(20, '.'));

            // Add padding right
            Console.WriteLine("Pad Right : {0} Stuff",
                randString.PadRight(20, '.'));

            // Trim whitespace
            Console.WriteLine("Trim : {0}",
                randString.Trim());

            // Make uppercase
            Console.WriteLine("Uppercase : {0}",
                randString.ToUpper());

            // Make lowercase
            Console.WriteLine("Lowercase : {0}",
                randString.ToLower());

            // Use Format to create strings
            string newString = String.Format("{0} saw a {1} {2} in the {3}",
                "Paul", "rabbit", "eating", "field");

            // You can add newlines with \n and join strings with +
            Console.Write(newString + "\n");

            // Other escape characters
            // \' \" \\ \t \a

            // Verbatim strings ignore escape characters
            Console.Write(@"Exactly What I Typed");

            // ----- IMPLICIT TYPING -----
            // You can use var to have C# figure out the 
            // data type

            var intVal = 1234;

            Console.WriteLine("\nintVal Type : {0}",
                intVal.GetType());
                  
            // ----- ARRAYS -----
            // Arrays are just boxes inside of a bigger box
            // that can contain many values of the same
            // data type
            // Each item is assigned a key starting at 0
            // and incrementing up from there

            // Define an array which holds 3 values
            // Arrays have fixed sizes
            int[] favNums = new int[3];

            // Add a value to the array
            favNums[0] = 23;

            // Retrieve a value 
            Console.WriteLine("favNum 0 : {0}", favNums[0]);

            // Create and fill array
            string[] customers = { "Bob", "Sally", "Sue" };

            // You can use var to create arrays, but the
            // values must be of the same type
            var employees = new[] { "Mike", "Paul", "Rick" };

            // Create an array of base objects which is the 
            // base type of all other types
            object[] randomArray = { "Paul", 45, 1.234 };

            // GetType knows its true type
            Console.WriteLine("randomArray 0 : {0}",
                randomArray[0].GetType());

            // Get number of items in array
            Console.WriteLine("Array Size : {0}",
                randomArray.Length);

            // Use for loop to cycle through the array
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array {0} : Value : {1}",
                i, randomArray[i]);
            }

            // Multidimensional arrays
            // When you define an array like arrName[5] you
            // are saying you want to create boxes stacked 
            // vertically

            // If you define arrName[2,2] you are saying
            // you want to have 2 rows high and 2 across
            string[,] custNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Smith2" } };

            // Get value in MD array
            Console.WriteLine("MD Value : {0}",
                custNames.GetValue(1, 1));

            // Cycle through the multidimensional array
            // Get length of multidimensional array column
            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                // Get length of multidimensional array row
                for (int j = 0; j < custNames.GetLength(1); j++)
                {
                    Console.Write("{0} ", custNames[i, j]);
                }
                Console.WriteLine();
            }

            // An array like arrName[2,2,3] would be like a 
            // stack of 3 spread sheets with 2 rows and 2
            // columns worth of data on each page

            // foreach can be used to cycle through an array
            int[] randNums = { 1, 4, 9, 2 };

            // You can pass an array to a function
            PrintArray(randNums, "ForEach");

            // Sort array
            Array.Sort(randNums);

            // Reverse array
            Array.Reverse(randNums);

            // Get index of match or return -1
            Console.WriteLine("1 at index : {0} ",
                Array.IndexOf(randNums, 1));

            // Change value at index 1 to 0
            randNums.SetValue(0, 1);

            // Copy part of an array to another
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;

            Array.Copy(srcArray, startInd, destArray,
                startInd, length);

            PrintArray(destArray, "Copy");

            // Create an array with CreateInstance
            Array anotherArray = Array.CreateInstance(typeof(int), 10);

            // Copy values in srcArray to destArray starting
            // at index 5 in destination
            srcArray.CopyTo(anotherArray, 5);

            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyTo : {0} ", m);
            }

            // Search for an element that matches the conditions
            // defined by the specified predicate
            int[] numArray = { 1, 11, 22 };
            Console.WriteLine("> 10 : {0}", Array.Find(numArray, GT10));

            // FindAll returns an array with all values that
            // match 
            // FindIndex returns the index of the match

            // ----- STRINGBUILDER -----
            // Each time you change a string you are actually
            // creating a new string which is inefficient
            // when you are working with large blocks of text
            // StringBuilders actually change the text
            // rather then make a copy

            // Create a StringBuilder with a default size
            // of 16 characters, but it grows automatically
            StringBuilder sb = new StringBuilder("Random Text");

            // Create a StringBuilder with a size of 256
            StringBuilder sb2 = new StringBuilder("More Stuff that is very important", 256);

            // Get max size
            Console.WriteLine("Capacity : {0}", sb2.Capacity);

            // Get length
            Console.WriteLine("Length : {0}", sb2.Length);

            // Add text to StringBuilder
            sb2.AppendLine("\nMore important text");

            // Define culture specific formating
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");

            // Append a format string
            string bestCust = "Bob Smith";
            sb2.AppendFormat(enUS, "Best Customer : {0}", bestCust);

            // Output StringBuilder
            Console.WriteLine(sb2.ToString());

            // Replace a string
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());

            // Clear a string builder
            sb2.Clear();

            sb2.Append("Random Text");

            // Are objects equal
            Console.WriteLine(sb.Equals(sb2));

            // Insert at an index
            sb2.Insert(11, " that's Great");

            Console.WriteLine("Insert : {0}", sb2.ToString());

            // Remove number of characters starting at index
            sb2.Remove(11, 7);

            Console.WriteLine("Remove : {0}", sb2.ToString());

            // ----- CASTING -----
            // If you want to cast from one type to another
            long num1 = 1234;
            int num2 = (int)num1;

            Console.WriteLine("Orig : {0} Cast : {1}",
                num1.GetType(), num2.GetType());

            // ----- CONDITIONALS -----
            // ----- IF / ELSE / -----
            // Relational Operators : > < >= <= == !=
            // Logical Operators : && || !

            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else if ((age > 13) && (age < 19))
            {
                Console.WriteLine("Go to high school");
            }
            else
            {
                Console.WriteLine("Go to college");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }

            Console.WriteLine("! true = " + (!true));





            // Excepts input up until a newline, but it is here to 
            // keep the console open after output
            // Read() excepts a single character
            Console.ReadLine();

        }

        // You can create your own functions (methods)
        private static void SayHello()
        {
            // Defines a variable that will store a string
            // of characters
            string name = "";

            Console.Write("What is your name : ");

            // Save the input the user provides
            name = Console.ReadLine();

            Console.WriteLine("Hello {0}", name);
        }

        static void PrintArray(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1} ", mess, k);
            }
        }

        private static bool GT10(int val)
        {
            return val > 10;
        }
    }
}

