using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Solutions
{
    class BinaryGap
    {
        static int singleCount = 0;
        static int zeroCount = 0;

        static int solution(int N)
        {

            bool start = false;
            zeroCount = 0;

            // divide input int to 2 until result is 0
            return divider(N, start);
        }

        static int divider(int res, bool start)
        {
            bool isOdd = res % 2 > 0;

            // start = true when  current result is 1  
            if(isOdd && !start)
                start = true;
            // if current result is 1 and previous was 1 - stop counting zeros
            else if(isOdd && start)
                singleCount = 0;

            if(!isOdd && start)
            {
                singleCount++;
                // save zero amount in case is it bigger then previous 
                if(singleCount > zeroCount)
                {
                    zeroCount = singleCount;
                }
            }
            res = res / 2;
            // count until result is 0
            if(res > 0)
                divider(res, start);
            return zeroCount;
        }

        //static void Main(string [] args)
        //{

        //    solution(1162);
        //    solution(74901729);
        //    solution(1376796946);
        //}
    }
}
