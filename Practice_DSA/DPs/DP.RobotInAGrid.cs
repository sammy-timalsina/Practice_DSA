using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public void getUniquePath2()
        {
            int mm = MaxArea();
            int[][] grid1s = new int[][]
            {
                new int[]{0,1}
            };
            int[][] grid2s = new int[][]
            {
                new int[]{0,0},
                new int[]{0,0}
            };
            int[][] grid3s = new int[][]
            {
                new int[]{0,0,0},
                new int[]{0,1,0},
                new int[]{0,0,0}
            };
            //  mgrid = grids.ToArray();
            int row = grid1s.Length;
            int col = grid1s[0].Length;
            int totPaths = UniquePathsWithObstacles(grid3s);
        }
        private int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int row = obstacleGrid.Length;
            int col = obstacleGrid[0].Length;
            int[,] dp = new int[row, col];
            if(obstacleGrid[0][0] == 1)
            {
                dp[0, 0] = 0;
            }
            else
            {
                dp[0, 0] = 1;
            }
            //initialize first row of dp
            for(int i=1;i<row;i++)
            {
                if (obstacleGrid[i][0] == 0)
                {
                    dp[i, 0] = dp[i - 1, 0];
                }
                else
                {
                    dp[i, 0] = 0;
                }
            }
            //initialize first column of dp
            for (int j = 1;  j< col; j++)
            {
                if (obstacleGrid[0][j] == 0)
                {
                    dp[0, j] = dp[0, j - 1];
                }
                else
                {
                    dp[0, j] = 0;
                }
            }

            for(int i =1;i<row;i++)
            {
                for(int j =1;j<col;j++)
                {
                    if(obstacleGrid[i][j] == 0)
                    {
                        dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                    }
                    else
                    {
                        dp[i, j] = 0;
                    }
                }
            }
            return dp[row-1, col-1];
        }
        private int MaxArea()
        {
            int[][] matrix = new int[][]
            {
                new int[]{1,1,1,1},
                new int[]{0,1,1,1},
                new int[]{0,1,1,1}
            };
            int row = matrix.Length;
            int col = matrix[0].Length;
            int[,] dp = new int[row, col];

            //update the first row with previous row + first row
            for (int i = 0; i < col; i++)
            {
                dp[0, i] = matrix[0][i];
            }
            for(int i=1;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    dp[i, j] = dp[i-1,j] + matrix[i][j]; 
                }
            }
            //calculate maximum area from each row 

            int maxArea = getMaxAreaCoveredByRectangleBars(dp, row, col);
            return maxArea;
        }
        private int getMaxAreaCoveredByRectangleBars(int[,] arr,int row, int col)
        {

            int maxArea = int.MinValue ;
            int i = 0; //row
            for(int r=0;r<col;i++)
            {
                for(int t=r+1;t<col;t++)
                {

                }
            }
            while (i < row)
            {
                int x = 0;
                int y = col - 1;
                while (x != y)
                {
                    int width = y - x;
                    int minHt = Math.Min(arr[i,x], arr[i, y]);
                    maxArea = Math.Max(minHt * width, maxArea);
                    if (arr[i, x] > arr[i, y])
                    {
                        y--;
                    }
                    else
                    { x++; }
                }
                i++;
            }
            return maxArea;
        }
    }
}
