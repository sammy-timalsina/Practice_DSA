using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Recursions
{
    public partial class Recursion
    {
        public int NumSquares(int n)
        {
            //variation of coin change problem
            List<int> vector = new List<int>();
            int[,] dp = new int[n+1,n+1];
            for(int i=0;i<=n;i++)
            {
                for(int j=0;j<=n;j++)
                {
                    dp[i, j] = -1;
                }
            }
            for(int i=1;i<=n;i++)
            {
                if(Math.Sqrt(i)%1==0)
                {
                    vector.Add(i);
                }
            }
            int ans = helperIter(n, vector);
            return ans;
        }
        private int helper(int n, List<int> nums, int ind, int[,] dp)
        {
           if( ind == 0)
            {
                if(n%nums[ind]==0)
                {
                    dp[n,ind] = n / nums[ind];
                    return dp[ind,n];
                }
                else
                {
                    return (int)100;
                }
            }
            if(dp[ind,n] != -1)
            {
                return dp[ind,n];
            }
            int pick = (int)100;
            if(nums[ind]<=n)
            {
                pick = 1+ helper(n - nums[ind], nums, ind,dp);
            }
            int dontPick = helper(n, nums, ind - 1,dp);
            int minVal = Math.Min(pick, dontPick);
            dp[ind,n] = minVal;
            return minVal;
        }
        private int helperIter(int n, List<int>nums)
        {
            int[,] dp = new int[nums.Count,n+1];
            for(int N = 0; N <= n; N++)
            {
              if(N% nums[0] == 0)
                {
                    dp[0,N] = N/ nums[0];  
                }
              else
                {
                    dp[0, N] = (int)1e9;
                }
            }
            for(int ind=1; ind<nums.Count; ind++)
            {
                for(int N=0;N<=n; N++)
                {
                    int pick = (int)1e9;
                    if (nums[ind] <= N)
                    {
                        pick = 1 + dp[ind,N - nums[ind]];
                    }
                    int dontPick = dp[ind - 1,N];
                    int minVal = Math.Min(pick, dontPick);
                    dp[ind, n] = minVal;
                }
            }
            return dp[nums.Count-1, n-1]; 
        }
    }
}
