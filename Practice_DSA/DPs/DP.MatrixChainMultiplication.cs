using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public void multiplyMatrices()
        {
            //input
            int[] mat = new int[] { 40, 20, 30, 10, 30 };
            int ii = 1;
            int jj = mat.Length - 1;
            int[,] dp = new int[jj + 1, jj + 1];
            for(int i=0;i<jj+1;i++)
            {
                for(int j=0;j<jj+1;j++)
                {
                    dp[i, j] = -1;
                }
            }
            int minOperations = multiplyMatrices(mat, ii, jj, dp);
        }
         int multiplyMatrices(int[]mat)
        {
            int ii = 1;
            int jj = mat.Length - 1;
            int[,] dp = new int[jj + 1, jj + 1];
            for (int i = 0; i < jj + 1; i++)
            {
                for (int j = 0; j < jj + 1; j++)
                {
                    if (i == j)
                    {
                        dp[i, j] = 0;
                    }
                }
            }
            return 0;
            
        }
        int multiplyMatrices(int[] arr,int i, int j, int[,] dp)
        {
            if(i==j)
            {
                return 0;
            }
            if(dp[i,j]!=-1)
            {
                return dp[i, j];
            }
            int min = int.MaxValue;
            int steps = 0;
            for (int k=i;k<j;k++)
            {
                steps =(arr[i - 1] * arr[k] * arr[j]) +multiplyMatrices(arr, i, k,dp)
                    + multiplyMatrices(arr, k + 1, j,dp);
                min = Math.Min(min, steps);
            }     
            return dp[i,j]=min;
        }
    }
}
