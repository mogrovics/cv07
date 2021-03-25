using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers =
            {
                2, 3, 7, 9, 4
            };

            string[] strings =
            {
                "text", "text1", "testingtext", "blabla"
            };

            Circle[] circles = { new Circle(3),
                                 new Circle(2),
                                 new Circle(7) };

            Rectangle[] rectangles = { new Rectangle(3, 5),
                                       new Rectangle(2, 2),
                                       new Rectangle(4, 3) };

            Ellipse[] ellipses = { new Ellipse(2, 3),
                                   new Ellipse(4, 4),
                                   new Ellipse(2, 5) };

            Triangle[] triangles = { new Triangle(2, 3, 5),
                                     new Triangle(4, 6, 7),
                                     new Triangle(2, 3, 6) };

            Square[] squares = { new Square(1),
                                 new Square(3),
                                 new Square (2) };

            Object2D[] objects = { new Circle(3), 
                                   new Triangle(2, 3, 5),
                                   new Square(4) };

            Console.WriteLine("Largest: " + Extremes.Largest(integers));
            Console.WriteLine("Smallest: " + Extremes.Smallest(integers));

            Console.WriteLine("Largest: " + Extremes.Largest(strings));
            Console.WriteLine("Smallest: " + Extremes.Smallest(strings));

            Console.WriteLine("Largest: " + Extremes.Largest(circles));
            Console.WriteLine("Smallest: " + Extremes.Smallest(circles));

            Console.WriteLine("Largest: " + Extremes.Largest(rectangles));
            Console.WriteLine("Smallest: " + Extremes.Smallest(rectangles));

            Console.WriteLine("Largest: " + Extremes.Largest(ellipses));
            Console.WriteLine("Smallest: " + Extremes.Smallest(ellipses));

            Console.WriteLine("Largest: " + Extremes.Largest(triangles));
            Console.WriteLine("Smallest: " + Extremes.Smallest(triangles));

            Console.WriteLine("Largest: " + Extremes.Largest(squares));
            Console.WriteLine("Smallest: " + Extremes.Smallest(squares));

            Console.WriteLine("Largest: " + Extremes.Largest(objects));
            Console.WriteLine("Smallest: " + Extremes.Smallest(objects));

            Console.ReadLine();
        }
    }
}
