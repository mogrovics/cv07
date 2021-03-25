using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    public class Circle : Object2D
    {
        private double radius;

        public Circle(double r)
        {
            Radius = r;
        }

        public double Radius { get => radius; set => radius = value; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return String.Format("Circle: radius = {0}, area = {1:0.00}", Radius, Area());
        }
    }
}
