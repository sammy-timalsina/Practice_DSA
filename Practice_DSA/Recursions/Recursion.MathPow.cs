using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Recursions
{
    public partial class Recursion
    {
        public void testMyPow()
        {
            int sqrt = IsPerfectSquareHelper(123);
            Dictionary<int,double> data = new Dictionary<int,double>();
            double ans = getPow(1000,1000, data);
        }
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
        double getPow(double x, int n, Dictionary<int,double> ds)
        {
            if (n == 1) return x;
            else if (n == -1) return 1 / x;
            else if (n == 0) return 1;
            if (ds.ContainsKey(n)) return ds[n];
            int n1 = 0;
            int n2 = 0;
            if(n%2 == 0)
            {
                n1 = n / 2;
                n2 = n1;
            }
            else
            {
                n1 = n / 2;
                n2 = (n - n1);
            }
            double ans = getPow(x, n1, ds) * getPow(x, n2, ds);
            if (!ds.ContainsKey(n1 + n2)) ds.Add(n1 + n2, ans);
            return ans;
        }
        public int IsPerfectSquareHelper(int num)
        {
            char c = ' ';
            int end = num / 2;
            int start = 1;
            int mid = 0;
            int ans1 = 0;
            int rem = 0;
            while(start<=end)
            {
                mid = start + (end - start)/2;
                if(mid == num/mid)
                {
                    rem = num % mid;
                    ans1 = mid;
                    break;
                }
                else if(mid > num/mid) end = mid - 1;
                else if(mid < num/mid) start = mid + 1;
            }
            if (rem == 0 && ans1 > 0) return ans1;
            else return -1;

        }

    }
}
