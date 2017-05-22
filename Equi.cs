using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Equi
    {
        public int equi(int [] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int res = 0;
            int leftSum = 0;
            int rightSum = 0;
            int i, j;
            int arrLength = A.Length;

            for(i = 0; i < arrLength; i++)
            {
                leftSum = 0;
                rightSum = 0;

                for(j = 0; j < i; j++)
                {
                    leftSum += A [j];
                }

                for(j = i + 1; j < arrLength; j++)
                {
                    rightSum += A [j];
                }
                if(leftSum == rightSum)
                {
                    res = i;
                }
            }
            return res;
        }
     
        static void Main(string [] args)
        {
            
        }
    }
}