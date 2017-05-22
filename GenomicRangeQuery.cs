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
            int [] res = new int [P.Length];
            int [] A = new int [S.Length + 1];
            int [] C = new int [S.Length + 1];
            int [] G = new int [S.Length + 1];

            for(int i = 0; i < S.Length; i++)
            {
                Console.WriteLine("index {0}", S [i].ToString());
                A [i + 1] = A [i] + (S [i].ToString() == "A" ? 1 : 0);
                G [i + 1] = G [i] + (S [i].ToString() == "G" ? 1 : 0);
                C [i + 1] = C [i] + (S [i].ToString() == "C" ? 1 : 0);
            }

            for(int j = 0; j < P.Length; j++)
            {
                int a = A [Q [j] + 1] - A [P [j]];
                int c = C [Q [j] + 1] - C [P [j]];
                int g = G [Q [j] + 1] - G [P [j]];

                res [j] = a > 0 ? 1 : c > 0 ? 2 : g > 0 ? 3 : 4;
            }

            return res;
        }
        static void Main(string [] args)
        {
            string S = "CAGCCTA";
            int [] P = { 2, 5, 0 };
            int [] Q = { 4, 5, 6 };
            solution(S, P, Q);
        }

    }



}
