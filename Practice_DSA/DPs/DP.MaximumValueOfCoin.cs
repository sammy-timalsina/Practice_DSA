using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        int cMax = int.MinValue;
        int cost = 0;
        public void testCaseforMaxValueOfCoins()
        {
            IList<IList<int>> piles = new List<IList<int>> { new List<int>() { 1, 100, 3 }, new List<int>() { 7, 8, 9 } };
            int k = 2;
            MaxValueOfCoins(piles, k);
        }
        public int MaxValueOfCoins(IList<IList<int>> piles, int k)
        {
            for(int i=0;i<piles.Count;i++)
            {
                dfs(piles, k, i);
                cost = 0;
            }
            return cMax;
        }
        private void dfs(IList<IList<int>> piles, int k, int i)
        {
            if (k == 0)
            {
                cMax = Math.Max(cMax, cost);
                return;
            }
            else if (k < 0)
            {
                return;
            }
            else if (i >= piles.Count) return;
            for(int ind=0;ind<k;ind++)
            {
                cost += piles[i][ind];
            }

        }
    }
}
