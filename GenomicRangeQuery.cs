using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Solutions
{
    class Solution
    {
       //100/100
        static int [] solution(string S, int [] P, int [] Q)
        {
            // creat arrays for each letter except T
            int [] res = new int [P.Length];
            int [] A = new int [S.Length + 1];
            int [] C = new int [S.Length + 1];
            int [] G = new int [S.Length + 1];

            // loop through  the string  and count how many times each letter meets in the string
            for(int i = 0; i < S.Length; i++)
            {
                // save count to the next element, adding previous value
                A [i + 1] = A [i] + (S [i].ToString() == "A" ? 1 : 0);
                G [i + 1] = G [i] + (S [i].ToString() == "G" ? 1 : 0);
                C [i + 1] = C [i] + (S [i].ToString() == "C" ? 1 : 0);
            }

            // lopp through the arrays Q,P.  
            for(int j = 0; j < P.Length; j++)
            {
                // dividing two values from each array 
                int a = A [Q [j] + 1] - A [P [j]]; // if result is 1 - it means between two indexes there is A.
                int c = C [Q [j] + 1] - C [P [j]];// if result is 1 - it means between two indexes there is B.
                int g = G [Q [j] + 1] - G [P [j]];// if result is 1 - it means between two indexes there is C.

                res [j] = a > 0 ? 1 : c > 0 ? 2 : g > 0 ? 3 : 4;
            }

            return res;
        }
       
    }



}
