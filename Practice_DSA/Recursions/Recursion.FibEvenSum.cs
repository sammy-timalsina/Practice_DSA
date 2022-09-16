using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Recursions
{
    public partial class Recursion
    {
        public void testCaseForProjectEulers()
        {
            //Testcase for fib
            //int ip = 4000001;
            //long ans = getEvenSumFromFib(ip);

            //test case for multipleof 5 or 3
            // int ans = getSumOfMultiplesOf3Or5(1000);

            //test case for prime factors
            long ip = 6008;
            //long ip = 122;
            long ans = getLargestPrimeFactor(ip);
        }
        public long getEvenSumFromFib(int n)
        {
            int a = 1;
            int b = 2;
            int c = 0;
            long sum = 0;
            for(int i = 0; c < n; i++)
            {
                if (b % 2 == 0)
                {
                    sum += b;
                }
                c = b + a;
                //do swap
                int temp = b;
                b = c;
                a = temp;
            }
            return sum;
        }
        private int getSumOfMultiplesOf3Or5(int n)
        {
            int sum = 0;
            for(int i=1;i<n;i++)
            {
                if(i%3 == 0 || i%5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        private long getLargestPrimeFactor(long n)
        {
            List<long> vector = new List<long> { 2,3 };
            for (long i = 5; i < n; i = i + 2)
            {
                for(long j=0;j<vector.Count;j++)
                {
                    if(i % vector[(int)j] == 0)
                    {
                        break;
                    }
                    else if(j == vector.Count-1)
                    {
                        vector.Add(i);
                        break;
                    }
                }
            }
            long ans = 0;
            long div = 0;
            for (long i=vector.Count-1;i>=0;i--)
            {
                
  
                long checkZero = n % vector[(int)i];
                if (checkZero == 0)
                {
                   
                    ans = vector[(int)i];
                    break;
                }
            }
            long y = n/ans;
            return ans;
        }
    }
}
