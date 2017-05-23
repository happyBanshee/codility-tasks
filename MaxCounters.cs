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

            int [] countersArr = new int [N];
            // use debt system - save how many points each counter need to "pay"
            int [] debtArr = new int [N];
            int debt = 0;

            int prevMaxValue = 0;

            // loop through the main array
            for(int i = 0; i < A.Length; i++)
            {
                int counterNum = A [i] == 0 ? A [i] : A [i] - 1;

                // increment function
                if(A [i] >= 1 && A [i] <= N)
                {
                    // check if current counter "paid" debt. Set it to max if not
                    if(debtArr [counterNum] != debt)
                    {
                        countersArr [counterNum] = debt;
                        debtArr [counterNum] = debt;
                    }
                    // increment current counter
                    countersArr [counterNum]++;

                    if(prevMaxValue < countersArr [counterNum])
                    {
                        prevMaxValue = countersArr [counterNum];
                        // debtArr [counterNum] = prevMaxValue;
                    }
                    // setMax
                } else if(A [i] == N + 1)
                {
                    // if it is time to set all counters to max value, save this max value as debt to all counters.
                    debt = prevMaxValue;
                }
            }
            // lopp through thre debt array to check which counter did not pay. Add them all debts.
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
