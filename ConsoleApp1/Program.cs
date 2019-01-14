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
        // This time we cover Abstract Classes, Abstract
        // Methods, Base Classes, Is, As, Casting and
        // more about Polymorphism

        static void Main(string[] args)
        {
            // We can store our shapes in
            // a Shape array as long as it 
            // contains subclasses of Shape
            Shape[] shapes = {new Circle(5),
            new Rectangle(4,5)};

            // Cycle through shapes and print
            // the area
            foreach (Shape s in shapes)
            {
                // Call the overidden method
                s.GetInfo();

                Console.WriteLine("{0} Area : {1:f2}",
                s.Name, s.Area());

                // You can use as to check if an
                // object is of a specific type
                Circle testCirc = s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }

                // You can use is to check the data
                // type
                if (s is Circle)
                {
                    Console.WriteLine("This isn't a Rectangle");
                }


                Console.WriteLine();
            }




            Console.ReadLine();

        }

    }

}
