using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class NumberOfDiscIntersections
    {
        //100%/75%
        static int numberOfDiscIntersections(int [] A)
        {
            long arrLength = A.Length;
            int maxPairs = 10000000;
            int intersected = 0;

            for(int i = 0; i < arrLength; i++)
            {
                int center = i;
                long radius = A [i];

                for(int j = 0; j < i; j++)
                {
                    long radius2 = A [j];
                    int center2 = j;

                    long step = center - center2;
                    long radiusSum = radius + radius2;



                    if(radiusSum >= step)
                    { intersected++; }

                    if(intersected > maxPairs)
                    {
                        return -1;
                    }
                }

            }
            // Console.WriteLine("intersected {0}", intersected);
            return intersected;
        }
    }
}
