using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// You use a namespace to define globally unique objects
namespace ConsoleApp1
{
    // A class defines the variables and methods used
    // by objects. I'll get more into this later
    class Program
    {

        static void Main(string[] args)
        {

            // ----- PASSING BY VALUE -----
            double x = 5;
            double y = 4;

            Console.WriteLine("5 + 4 = {0}",
                GetSum(x, y));

            // Even though the value for x changed in 
            // method it remains unchanged here
            Console.WriteLine("x = {0}",
                x);

            // ----- OUT PARAMETER -----
            // You can pass a variable as an output 
            // variable even without assigning a
            // value to it
            int solution;

            // A parameter passed with out has its
            // value assigned in the method
            DoubleIt(15, out solution);

            Console.WriteLine("15 * 2 = {0}",
                solution);




            // Excepts input up until a newline, but it is here to 
            // keep the console open after output
            // Read() excepts a single character
            Console.ReadLine();

        }

        // ----- OUT PARAMETER -----
        // A parameter marked with out must be assigned 
        // a value in the method
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        // ----- PASS BY VALUE -----
        // By default values are passed into a method
        // and not a reference to the variable passed
        // Changes made to those values do not effect the
        // variables outside of the method

        // If you assign a value then it is optional to 
        // pass
        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }



    }
}

