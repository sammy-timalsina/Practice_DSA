using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public BigInteger fibonacciModified(int t1, int t2, int n)
        {

            BigInteger[] mf = new BigInteger[n + 1];
            for (int i = 1; i <= n; i++)
            {
                mf[i] = 0;
            }

            return fibonacciModified(t1, t2, n, mf);
        }
        private BigInteger fibonacciModified(int t1, int t2, int n, BigInteger[] mf)
        {
            if (n == 1)
            {
                mf[1] = t1;
                return mf[1];
            }
            if (n == 2)
            {
                mf[2] = t2;
                return mf[2];
            }
            //
            if (mf[n] != 0)
            {
                return mf[n];
            }
            //

            mf[n] = fibonacciModified(t1, t2, n - 2, mf) + fibonacciModified(t1, t2, n - 1, mf) * fibonacciModified(t1, t2, n - 1, mf) * fibonacciModified(t1, t2, n - 1, mf);
            return mf[n];
        }
    }
}
