using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        //Input: nums = [1,2,3], target = 4
        //Output: 7
        //Explanation:
        //The possible combination ways are:
        //(1, 1, 1, 1)
        //(1, 1, 2)
        //(1, 2, 1)
        //(1, 3)
        //(2, 1, 1)
        //(2, 2)
        //(3, 1)
        //Note that different sequences are counted as different combinations.
        public int CombinationSum4(int[] nums, int target)
        {
            int[,] dp = new int[nums.Length + 1, target + 1];
            for (int i = 0; i <= nums.Length; i++)
            {
                for (int j = 0; j <= target; j++)
                {
                    dp[i, j] = -1;
                }
            }
            return CombinationSum4(nums, target, nums.Length-1,dp);           
        }
        public int CombinationSum4Iter(int[] nums, int target)
        {
            int[,] dp = new int[nums.Length + 1, target + 1];
            for (int i = 0; i <= nums.Length; i++)
            {
                for (int j = 0; j <= target; j++)
                {
                  if(i==0)
                    {
                        if(j%nums[i]==0)
                        {
                            dp[i, j] = j / nums[i];
                        }
                       else
                        {
                            dp[i, j] = 0;
                        }
                    }
                  else
                    {
                        if (i < nums.Length)
                        {
                            int take = 0;
                            int nottake = 0;
                            if (nums[i] <= j)
                            {
                                take = dp[i, j - nums[i]];
                            }
                            nottake = dp[i - 1, j];
                            dp[i, j] = take + nottake;
                        }
                    }
                }
            }
            return dp[nums.Length-1, target];
        }
        private int CombinationSum4(int[] nums, int target, int ind, int[,]dp)
        {
            if ( target == 0)
            {
                dp[ind, target] = 1;
                return 1;
            }
            else if(ind==0 && target!=0)
            {
                if (target % nums[ind] == 0)
                {
                    dp[ind, target] = target / nums[ind];
                }
                else
                {
                    dp[ind, target] = 0;
                }
                return dp[ind, target];
            }
            if(dp[ind,target]!=-1)
            {
                return dp[ind, target];
            }

            int take = 0;
            if(nums[ind]<=target)
            {
                take =CombinationSum4(nums, target - nums[ind], ind, dp);
            }
            int nottake = CombinationSum4(nums, target, ind - 1, dp);
            dp[ind, target] = take+nottake;
            return dp[ind, target];
        }
    }
}
