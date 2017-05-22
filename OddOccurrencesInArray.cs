using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class OddOccurrencesInArray
    {
        // 100%/100%
        static int oddOccurrencesInArray(int [] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            var arrLength = A.Length;
            // odd length
            int isOddLength = arrLength % 2;
            // N length

            int isNLength = arrLength;
            // each can be paired

            if(isOddLength != 1)
            {
                return 0;
            }

            var dict = new Dictionary<int, int>();
            foreach(int d in A)
            {
                if(dict.ContainsKey(d))
                    dict [d]++;
                else
                    dict.Add(d, 1);
            }
            int res = dict.FirstOrDefault(x => x.Value % 2 == 1).Key;

            return res;
        }

    }
}
