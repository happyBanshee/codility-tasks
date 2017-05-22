using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class PermCheck
    {
        // 70%
        static int permCheck(int [] A)
        {
            int isPermut = 0;
            int arrLength = A.Length;
            int step = 0;
            int count = 0;

            for(int i = 0; i < arrLength; i++)
            {
                count = arrLength - i;
                // TODO: indexOf slow down the check!!!
                int index = Array.IndexOf(A, count);
                var isPresent = index != -1;

                if(isPresent)
                {
                    step++;

                    if(arrLength == 1)
                    {
                        return 1;
                    }
                } else
                {
                    return 0;
                }
            }
            isPermut = arrLength > 0 && (arrLength == step) ? 1 : 0;

            return isPermut;
        }
    }
}