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
        //Intersection of sets
        static int numberOfDiscIntersections(int [] A)
        {
            long arrLength = A.Length;
            int maxPairs = 10000000;
            int intersected = 0;

            // lopp through the array of all disks
            for(int i = 0; i < arrLength; i++)
            {
                // save radius and center
                int center = i;
                long radius = A [i];

                // check current disk with previous only 
                for(int j = 0; j < i; j++)
                {
                    long radius2 = A [j];
                    int center2 = j;

                    // distance between two centers
                    long step = center - center2;
                    long radiusSum = radius + radius2;

                    // if step bigger then radius sum of two disks - disks don't intersect
                    if(radiusSum >= step)
                    { intersected++; }

                    // return -1 of there is no intersections
                    if(intersected > maxPairs)
                    {
                        return -1;
                    }
                }

            }
            return intersected;
        }
    }
}
