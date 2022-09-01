using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public int MinFallingPathSum(int[][] matrix)
        {
            int row = matrix.Length;
            int col = matrix[0].Length;
            int[,] dp = new int[row,col];
            for(int i = 0; i< row;i++)
            {
                for(int j = 0; j< col;j++)
                {
                    if(i==0)
                    {
                        dp[i, j] = matrix[i][j];
                    }
                    else if(j==0)
                    {
                        dp[i, j] = matrix[i][j] + Math.Min(dp[i - 1, j], dp[i - 1, j + 1]);
                    }
                    else if(j==col-1)
                    {
                        dp[i, j] = matrix[i][j] + Math.Min(dp[i - 1, j - 1], dp[i-1,j]);
                    }
                    else
                    {
                        dp[i, j] = matrix[i][j] + Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i - 1, j + 1]));
                    }
                }
            }
            int min = int.MaxValue;
            for(int i=0;i<col;i++)
            {
                min = Math.Min(min, dp[row - 1,i]);
            }
            return min;
        }
    }
}
