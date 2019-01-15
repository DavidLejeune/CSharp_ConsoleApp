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

            // Create a Vehicle object
            Vehicle buick = new Vehicle("Buick",
                4, 160);

            // Check if Vehicle implements 
            // IDrivable
            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven", buick.Brand);
            }



            Console.ReadLine();

        }

    }

}
