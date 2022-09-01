using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public void RodCuttingTestCase()
        {
            int[] P = new int[] { 1, 5, 8, 9, 10, 17, 17, 20 };
            int[] L = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int len = 50;
            int profit = MaxProfitToCutRod(P, L, len,L.Length-1);
        }
        private int MaxProfitToCutRod(int[]P,int[]L, int len, int index)
        {
            //base case    
            if(index == 0)
            {
                if(L[index]<=len)
                {
                    return P[index];
                }
                else
                {
                    return 0;
                }
            }
            //pick
            int pick = 0;
            if(L[index]<=len)
            {
                pick = P[index]+MaxProfitToCutRod(P, L, len - L[index], index);
            }
            int dontPick = MaxProfitToCutRod(P, L, len, index - 1);
            return Math.Max(pick, dontPick);
        }
        private int MinCost(int n, int[] cuts)
        {
            //https://leetcode.com/problems/minimum-cost-to-cut-a-stick/
            return 0;
        }

    }
}
