using System;
using System.Collections.Generic;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public bool IsHappy(int n)
        {
            string sNum = n.ToString();
            List<int> bucket = new List<int>();
            bucket.Add(n);
            while (true)
            {
                int sqSum = 0;
                for (int i = 0; i < sNum.Length; i++)
                {
                    int numm = Convert.ToInt32(sNum[i].ToString());
                    sqSum = sqSum + numm * numm;
                }
                if (sqSum == 1)
                {
                    return true;
                }
                else if (sqSum == 0)
                {
                    return false;
                }
                else if (bucket.Contains(sqSum))
                {
                    return false;
                }
                sNum = sqSum.ToString();
                bucket.Add(sqSum);
            }
        }
    }
}
