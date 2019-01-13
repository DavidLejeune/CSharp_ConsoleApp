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

            // ----- PARAMS -----
            // You are able to pass a variable amount
            // of data of the same data type into a 
            // method using params. You can also pass
            // in an array. 
            Console.WriteLine("1 + 2 + 3 + 5 = {0}",
                GetSumMore(1, 2, 3, 5));





            // Excepts input up until a newline, but it is here to 
            // keep the console open after output
            // Read() excepts a single character
            Console.ReadLine();

        }


        // ----- PARAMS -----
        // The params array must be the last parameter
        // in the list
        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

    }
}

