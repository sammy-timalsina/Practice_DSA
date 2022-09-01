using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public void getHowmanyways()
        {
            int[] arr = new int[] { 1,2,3 };
            int target = 4;
            int index = arr.Length - 1;
            int[,] dp = new int[arr.Length, target+1];
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0; j<target;j++)
                {
                    dp[i, j] = -1;
                }
            }
            int totWays = getHowmanyways(arr, index, target, dp);
        }
        int getHowmanyways(int[] arr, int index, int target, int[,]dp)
        {
            if(index ==0 || target == 0)
            {
                if(target%arr[index] == 0)
                {
                    dp[index, target] = 1;
                    return 1;
                }
                else
                {
                    dp[index, target] = 0;
                    return 0;
                }
            }
            if(dp[index,target]!=-1)
            {
               // return dp[index, target];
            }
            //pick
            int pick = 0;
            if(arr[index]<=target)
            {
                pick = getHowmanyways(arr, index, target - arr[index],dp);
            }
            int notPick = getHowmanyways(arr, index-1, target, dp);
            dp[index, target] = pick + notPick;
            return dp[index, target];
        }
        int getHowmanywaysIter(int[] arr, int index, int target)
        {
            return 0;
        }
    }
}
