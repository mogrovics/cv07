using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    public class Extremes
    {
        public static T Largest<T>(T[] listObjects) where T : IComparable
        {
            T maximum = listObjects[0];

            foreach (T obj in listObjects)
                if (obj.CompareTo(maximum) > 0)
                    maximum = obj;
            
            /*for (int i = 1; i < listObjects.Length; i++)
            {
                if (listObjects[i].CompareTo(maximum) > 0)
                {
                    maximum = listObjects[i];
                }
            }*/

            return maximum;
        }

        public static T Smallest<T>(T[] listObjects) where T : IComparable
        {
            T minimum = listObjects[0];

            foreach (T obj in listObjects)
                if (obj.CompareTo(minimum) < 0)
                    minimum = obj;

            /*for (int i = 1; i < listObjects.Length; i++)
            {
                if (listObjects[i].CompareTo(minimum) < 0)
                {
                    minimum = listObjects[i];
                }
            }*/

            return minimum;
        }
    }
}
