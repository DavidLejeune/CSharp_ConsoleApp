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

        }

    }

}
