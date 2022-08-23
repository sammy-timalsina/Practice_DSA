using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        //{1, 0, 0, 0}
        //{1, 1, 0, 1}
        //{ 0, 1, 0, 0}
        //{ 1, 1, 1, 1}

        public void getNoOfWays()
        {
            //{1, 0, 0, 0}
            //{1, 1, 0, 1}
            //{ 0, 1, 0, 0}
            //{ 1, 1, 1, 1}
            int[][] mat = new int[][]
            {
                new int[]{0,  0, 0, 0},
                new int[]{0, -1, 0, 0},
                new int[]{ -1, 0, 0, 0},
                  new int[]{0,  0, 0, 0}
            };
            int ans1 = printAllPossibleWaysToReachAtBottomIter(mat, mat[0].Length, mat.Length);
            int an2 = getNoOfWays(mat, mat[0].Length-1, mat.Length-1);

        }
        private int getNoOfWays(int[][] mat, int row, int col)
        {
            if(row< 0 || col <0)
            {
                return 0;
            }
            if(row == 0 && col == 0)
            {
                if(mat[0][0]!=-1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            if(mat[row][col]!=-1)
            {
                return getNoOfWays(mat, row - 1, col) + getNoOfWays(mat, row, col - 1);
            }
            else
            {
                return 0;
            }
        }
        private int getAllPossibleWaysToReachAtBottom(int[][] mat, int row, int col)
        {
            if (row < 0 || col < 0)
            {
                return 0;
            }
            if (row == 0 && col == 0)
            {
                return 1;
            }

            return getAllPossibleWaysToReachAtBottom(mat, row - 1, col) + getAllPossibleWaysToReachAtBottom(mat, row, col - 1);
        }
        private int getAllPossibleWaysToReachAtBottomIter(int[][] mat, int row, int col)
        {
            int[,] dp = new int[row+1,col+1];
            for(int i=0;i<row+1;i++)
            {
                for(int j=0;j<col+1;j++)
                {
                    if(i==0 || j==0)
                    {
                        dp[i, j] = 0;
                    }
                    else if(i==1 && j==1)
                    {
                        dp[i, j] = 1;
                    }
                    else
                    {
                        dp[i,j] =dp[i - 1, j] + dp[i, j - 1];
                    }
                }
            }
            return dp[row,col];
        }
        private int printAllPossibleWaysToReachAtBottomIter(int[][] mat, int row, int col)
        {
            int[][] dmat = new int[][]
{
                new int[]{1,  2, 3, 4},
                new int[]{5, 6, 7, 8},
                new int[]{9, 10, 11, 12},
                  new int[]{13,  14, 15, 16}
};
            int[,] dp = new int[row + 1, col + 1];
            List<List<int>> dpMat = new List<List<int>>();
            List<int> [] ls = new List<int>[5];

           for(int i=0;i<5;i++)
            {
                ls[i] = new List<int>();
                dpMat.Add(ls[i]);
            }
            for (int i = 0; i < row + 1; i++)
            {
                for (int j = 0; j < col + 1; j++)
                {
                    if (i == 0 || j == 0)
                    {
                       
                        dp[i, j] = 0;
                    }
                    else if (i == 1 && j == 1)
                    {

                        dp[i, j] = 1;
                    }
                    else
                    {

                        dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                    }
                }
            }
            return dp[row, col];
        }
    }
}
