using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class MaxCounters
    {
        // 100/100
        static int [] maxCounters(int N, int [] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int [] countersArr = new int [N];
            int [] debtArr = new int [N];
            int debt = 0;

            int prevMaxValue = 0;

            for(int i = 0; i < A.Length; i++)
            {
                int counterNum = A [i] == 0 ? A [i] : A [i] - 1;

                if(A [i] >= 1 && A [i] <= N)
                {
                    if(debtArr [counterNum] != debt)
                    {
                        countersArr [counterNum] = debt;
                        debtArr [counterNum] = debt;
                    }

                    //increment
                    countersArr [counterNum]++;

                    if(prevMaxValue < countersArr [counterNum])
                    {
                        prevMaxValue = countersArr [counterNum];
                        // debtArr [counterNum] = prevMaxValue;
                    }
                } else if(A [i] == N + 1)
                {
                    // setMax
                    //debtArr [counterNum] = prevMaxValue;
                    debt = prevMaxValue;
                }
            }

            for(int x = 0; x < debtArr.Length; x++)
            {
                bool notPaid = debtArr [x] != debt;
                if(notPaid)
                { countersArr [x] = debt; }
            }

            return countersArr;
        }
    }
}
