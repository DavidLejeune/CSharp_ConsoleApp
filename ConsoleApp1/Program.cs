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

            Animal cat = new Animal();

            // Call the setter
            cat.SetName("Whiskers");

            // Set the property
            cat.Sound = "Meow";

            Console.WriteLine("The cat is named {0} and says {1}",
                cat.GetName(), cat.Sound);

            // Test auto generated getters and setters
            cat.Owner = "Derek";

            Console.WriteLine("{0} owner is {1}",
                cat.GetName(), cat.Owner);

            // Get the read-only id number
            Console.WriteLine("{0} shelter id is {1}",
                cat.GetName(), cat.idNum);

            // Test static property
            Console.WriteLine("# of Animals : {0}",
                Animal.NumOfAnimals);


            Console.ReadLine();

            // Excepts input up until a newline, but it is here to 
            // keep the console open after output
            // Read() excepts a single character
            Console.ReadLine();

        }

        // ----- STRUCTS -----
        // A struct is a user defined type that
        // contain multiple fields and methods

        struct Rectangle
        {
            public double length;
            public double width;

            // You can create a constructor method
            // that will set the values for fields
            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }

    }





}

