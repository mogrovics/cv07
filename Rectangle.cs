using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    public class Rectangle : Object2D
    {
        private double edgeA;
        private double edgeB;

        public Rectangle(double a, double b)
        {
            EdgeA = a;
            EdgeB = b;
        }

        public double EdgeA { get => edgeA; set => edgeA = value; }
        public double EdgeB { get => edgeB; set => edgeB = value; }

        public override double Area()
        {
            return EdgeA * EdgeB;
        }

        public override string ToString()
        {
            return String.Format("Rectangle: a = {0}, b = {1}, area = {2:0.00}", EdgeA, EdgeB, Area());
        }
    }
}
