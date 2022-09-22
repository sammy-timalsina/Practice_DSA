using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        int maxV = Convert.ToInt32(1E9);
        int[] vals = new int[10000];
        bool[] result = new bool[10000];
        public int CoinChange(int[] coins, int amount)
        {
            int ans = helper(coins, amount);
            return ans;
        }
        private int helper(int[] coins, int amount)
        {
         
            if (amount < 0) return maxV;
            else if (amount == 0) return 0;
            if (result[amount])
                return vals[amount];
            int best = maxV;
            foreach(int x in coins)
            {
                best = Math.Min(best, 1 + helper(coins, amount - x));
            }
            vals[amount]= best;
            result[amount] = true;
            return best;    
        }

    }
}
