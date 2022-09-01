using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public void GetMaximumGold()
        {
            int[][] grid = new int[][]
            {
                new int[]{1,3,3},
                new int[]{2,1,4},
                new int[]{0,6,4}
            };
            int[][] grid1 = new int[][]
{
                new int[]{1,3,1,5},
                new int[]{2,2,4,1},
                new int[]{5,0,2,3},
                new int[]{0,6,1,2}
};
            int[][] grid2 = new int[][]
{
                new int[]{10,33,13,15},
                new int[]{22,21,4,1},
                new int[]{5,0,2,3},
                new int[]{0,6,14,2}
};
            int ans = GetMaximumGold(grid2);
        }
        int GetMaximumGold(int[][] grid)
        {
            int row = grid.Length;
            int col = grid[0].Length;
            int[,] dp = new int[row,col];
            //initialize first column of dp
            for(int i=0;i<row;i++)
            {
                dp[i, 0] = grid[i][0];
            }
            int j = 0;
            while(j<col)
            {
                int i = 0;
                while(i<row)
                {
                    if(j == 0) //first column
                    {
                        dp[i, j] = grid[i][j];
                    }
                    else if( i==0) //first row
                    {
                        dp[i, j] = grid[i][j] + Math.Max(dp[i, j - 1], dp[i + 1, j - 1]);
                    }
                    else if( i == row-1) // last row
                    {
                        dp[i, j] = grid[i][j] + Math.Max(dp[i, j - 1], dp[i - 1, j - 1]);
                    }
                    else
                    {
                        dp[i, j] = grid[i][j] + Math.Max(dp[i, j - 1], Math.Max(dp[i - 1, j - 1], dp[i + 1, j - 1]));
                    }
                    i++;
                }
                j++;
            }
            int max = int.MinValue;
            for(int i=0;i < row;i++)
            {
                max = Math.Max(max, dp[i, col-1]);
            }
            return max;
        }
    }
}
