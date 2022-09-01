using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Recursions
{
    public partial class Recursion
    {
        public double MyPow(double x, int n)
        {
            bool flag = false;
            int rem = n % 2;
            if(rem == 1 || rem == -1)
            {
                flag = true;
            }
            if((x == 1 || x == -1) && !flag )
            {
                return 1;
            }
             if((x == 1 || x == -1) && flag)
            {
                return -1;
            }

            if (n < 0)
            {
                return 1 / MyPowHelper(x, -n);
            }
            return MyPowHelper(x, n);
            if (n<0)
            {
                return 1 / MyPowHelper(x, -n);
            }
            return MyPowHelper(x, n);

        }
        double MyPowHelper(double x, int n)
        {
            //if (n == 0)
            //    return 1;
            //return x * MyPowHelper(x, n - 1);
            int i = 1;
            double mul = 1;
            while(i<=n)
            {
                mul = mul * x;               
                i++;
            }
            return mul;
        }
       
    }
}
