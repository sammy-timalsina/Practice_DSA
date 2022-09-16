using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public int NthUglyNumber(int n)
        {
            int i = 1;
            int pos = 0;
            int count = 0;
            int size = int.MaxValue/2;
            bool[] ds = new bool[size];
            while(count<n)
            {
                bool isUgly = IsUgly(i, ds);
                ds[i] = isUgly;
                if(ds[i])
                {
                    pos = i;
                    i++;
                    count++;
                }
                else
                {
                    i++;
                }
            }
            return pos;
        }
        //        An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.

        //Given an integer n, return true if n is an ugly number.
        public bool IsUgly(int n, bool[] ds)
        {
            if(n==1)
                return true;
            else if(n ==0)
                return false;
            if(ds[n])
            {
                return ds[n];
            }
           if(n%2 == 0)
            {
               return IsUgly(n / 2,ds);
            }
           else if(n%3 == 0)
            {
               return IsUgly(n/3,ds);
            }
           else if(n%5 == 0)
            {
               return IsUgly(n / 5,ds);
            }
           else
            {
                return false;
            }
    
        }
        bool IsUglyIterative(int n, Dictionary<long, bool> ds)
        {
            if(n==1)return true;
            while( n!= 1 || n!=0)
            {
                if (ds.ContainsKey(n))
                    return ds[n];
                if(n ==0)
                {
                    return false ;
                }
                else if(n%2 ==0)
                {
                    n = n / 2;
                }
                else if( n%3 == 0)
                {
                    n = n / 3;
                }
                else if(n %5 == 0)
                {
                    n = n / 5;
                }
                else if(n==1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
