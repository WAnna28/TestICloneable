using System;
using TestICloneable.Models;

namespace TestICloneable
{
    // When you want to give your custom type the ability to return an identical copy of itself to the caller,
    // you may implement the standard ICloneable interface.
    //public interface ICloneable
    //{
    //    object Clone();
    //}

    // Obviously, the implementation of the Clone() method varies among your classes.However, the basic
    // functionality tends to be the same: copy the values of your member variables into a new object instance of
    // the same type and return it to the user.

    class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            // Two references to same object!
            Point p1 = new Point(50, 50);
            Point p2 = p1;
            p2.X = 0;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine();

            // Example 2
            Point p3 = new Point(100, 100);
            Point p4 = (Point)p3.Clone();

            // Change p2.X (which will not change p1.X).
            p4.X = 0;

            // Print each object.
            Console.WriteLine(p3);
            Console.WriteLine(p4);

            // Example 3
            ExtraPoint p5 = new ExtraPoint(100, 100, "Petros");
            ExtraPoint p6 = (ExtraPoint)p5.Clone();

            Console.WriteLine("\nBefore modification:");
            Console.WriteLine("p5: {0}", p5);
            Console.WriteLine("p6: {0}", p6);
            p6.desc.PetName = "My new Point";
            p6.X = 9;

            Console.WriteLine("After modification:");
            Console.WriteLine("p5: {0}", p5);
            Console.WriteLine("p6: {0}", p6);

            Console.ReadLine();
        }
    }
}
