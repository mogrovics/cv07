using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    public abstract class Object2D : I2D, IComparable
    {
        public int CompareTo(object obj)
        {
            if (((Object2D)obj).Area() > Area())
            {
                return 0;
            }

            else
            {
                return 1;
            }
        }

        public abstract double Area();
    }
}