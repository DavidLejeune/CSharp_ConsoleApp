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

            // ----- OBJECT ORIENTED PROGRAMMING -----
            // A class models real world objects by
            // defining their attributes (fields) and
            // capabilities (methods)
            // Then unlike with structs you can 
            // inherit from a class and create more
            // specific subclass types

            // Add a class Project -> Add Class

            // Create an Animal object
            // You could also assign values like
            // fox.name = "Red"
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaaw"
            };

            Animal dog = new Animal()
            {
                name = "Blue",
                sound = "Woef"
            };
            // Call the static method
            Console.WriteLine("# of Animals {0}",
                Animal.GetNumAnimals());

            

            // Excepts input up until a newline, but it is here to 
            // keep the console open after output
            // Read() excepts a single character
            Console.ReadLine();

        }

    

    }





}

