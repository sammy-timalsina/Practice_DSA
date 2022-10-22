using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public int NumDecodings(string s)
        {
            int anss= NumRollsToTarget(6, 6, 8);
            int xorVal = 3 ^ 79; 
            int count = 0;
            int ind = 0;
            Dictionary<string, int> ds = new Dictionary<string, int>();
            return dp(s, string.Empty, 0, ds);
            //bt(s,ind,ref count);
            //return count;
        }
        public int NumRollsToTarget(int n, int k, int target)
        {
            int count = 0;
            int[] arr = new int[k];
            for (int i = 0; i < k; i++)
            {
                arr[i] = i + 1;
            }
            int[] results = new int[1000];
            bool[] visited = new bool[1000];
            int[,] dd = new int[1000, 1000];
            int ans = ddp(arr, n, k, target, results, visited, dd);
            return ans;
        }
        private int dp(string s, string subStr, int ind, Dictionary<string, int> LookUpTbl)
        {
            if (ind > s.Length)
            {
                return 0;
            }
            else if (ind == s.Length)
                return 1;
            int len = s.Length - 1;
            string sub = string.Empty;
            if (ind < s.Length)
            {
                sub = s.Substring(ind, s.Length-ind);
            }
            if (LookUpTbl.ContainsKey(sub))
                return LookUpTbl[sub];
            //pick one index
            int pickOne = dp(s, sub, ind + 1, LookUpTbl);
            //pick two index;
            int pickTwo = 0;
            if (ind < len)
            {
                string s2 = s.Substring(ind, 2);
                int s2Int = Convert.ToInt16(s2);
                if (s2Int <= 26 && s2[0] != 0)
                {
                    pickTwo = dp(s, sub, ind + 2, LookUpTbl);
                }
            }
            if (!LookUpTbl.ContainsKey(sub))
                LookUpTbl.Add(sub, pickOne + pickTwo);
            return pickOne + pickTwo;
        }
        private int ddp(int[] arr, int n, int k, int target,int[] results, bool[] visited, int[,] dd)
        {
            if (n <= 0)
            {
                if (target == 0)
                    return 1;
                return 0;
            }
            else if (target < 0)
                return 0;
            else if (dd[n, target] != 0)
                return dd[n, target];
            // if(visited[target])
            // {
            //   return results[target];
            // }
            int total = 0;
            for (int i = 0; i < k; i++)
            {
                total += ddp(arr, n - 1, k, target - arr[i], results, visited, dd);
                dd[n, target] = total;
                //results[target] = total;
                //visited[target] = true;
            }
           
            return total;
        }
    }
}
