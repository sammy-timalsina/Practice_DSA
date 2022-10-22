using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public void testCaseForNumOFPaths()
        {
            // Input: grid = [[5, 2, 4],[3,0,5],[0,7,2]], k = 3
            int k = 3;
            int[][] grid = new int[][]
            {
                new int[]{5,2,4},
                new int[]{3,0,5},
                new int[]{0,7,2}
            };
            NumberOfPaths(grid, k);
        }
        public int NumberOfPaths(int[][] grid, int k)
        {
            //recursive solution
            int count = 0;
            int sum = 0;
            helperx(grid, 0, 0, k, sum, ref count);
            return count;
        }
        private void helperx(int[][] grid, int row, int col, int k, int sum, ref int count)
        {
            if (row == grid.Length - 1 && col == grid[0].Length - 1)
            {
                int newSum = grid[row][col] + sum;
                if (newSum % k == 0)
                {
                    count++;
                }
                return;
            }
            else if (row >= grid.Length || col >= grid[0].Length)
            {
                return;
            }
            sum = sum + grid[row][col];
            helperx(grid, row, col + 1, k, sum, ref count);
            helperx(grid, row + 1, col, k, sum, ref count);
        }
    }
}
