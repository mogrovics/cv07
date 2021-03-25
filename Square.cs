using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    public class Square : Object2D
    {
        private double edgeA;

        public Square(double a)
        {
            EdgeA = a;
        }

        public double EdgeA { get => edgeA; set => edgeA = value; }

        public override double Area()
        {
            return Math.Pow(EdgeA, 2);
        }

        public override string ToString()
        {
            return String.Format("Square: a = {0}, area = {1:0.00}", EdgeA, Area());
        }
    }
}
