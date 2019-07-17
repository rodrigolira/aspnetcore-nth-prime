using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreNthPrimeNumber.Web.Code
{
    public class NthPrime
    {
        public static long Calculate(int nth)
        {
            // from: https://stackoverflow.com/questions/13001578/i-need-a-slow-c-sharp-function
            int count = 0;
            long a = 2;
            while (count < nth)
            {
                long b = 2;
                int prime = 1; // to check if found a prime
                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                {
                    count++;
                }
                a++;
            }
            return (--a);
        }
    }
}
