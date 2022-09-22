using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        List<int> ds = new List<int>();
        int minV = int.MaxValue;
        public void testCaseForMinEffort()
        {
            //https://leetcode.com/problems/path-with-minimum-effort/
            int[][] ht = new int[][]
            {
                new int[]{1,2,3},
                new int[]{3,8,4},
                new[] {5,3,5}
            };
            int[][] ht2 = new int[][]
     {
                new int[]{1,2,3}
     };
            int[][] ht3 = new int[][]
{
                new int[]{1},
                new int[] {2},
                new int[] {3}
};
            //[411,412,413,414,415,416,417,418,419,420,421,422]
            // 9864
            //[1,2,3,4,5,6,7,344,454,333]
            //  9999
            CoinChange(new int[] { 1, 2, 5}, 10);
            // CoinChange(new int[] { 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422 }, 9864);
           // MinimumEffortPath(ht3);
        }
        public int MinimumEffortPath(int[][] heights)
        {
            int row = heights.Length;
            int col = heights[0].Length;
            if (row == 1 && col == 1) return 0;
            bool[,] visited = new bool[row, col];
           
            int prev = heights[0][0];
            int ans1 = minV; int ans2 = minV;
            int diff1 = int.MinValue; int diff2 = int.MinValue;
            if (row > 1 && col > 1)
            {
                helper(heights, 0, 1, visited, prev, int.MinValue);
                ans1 = minV;
                helper(heights, 1, 0, visited, prev, int.MinValue);
                ans2 = minV;
                diff1 = Math.Abs(heights[0][1] - prev);
                diff2 = Math.Abs(heights[1][0] - prev);
            }
            else if (col == 1)
            {
                helper(heights, 1, 0, visited, prev, int.MinValue);
                ans1 = minV;
            }
            else if(row == 1)
            {
                helper(heights, 0, 1, visited, prev, int.MinValue);
                ans2 = minV;
            }          
            ans1 = Math.Max(ans1, diff1);   
            ans2 = Math.Max(ans2, diff2);
            int ans = Math.Min(ans1,ans2);
            return ans;
        }
        private void helper(int[][] heights, int row, int col, bool[,] visited,int prev, int maxValue)
        {
            
            if (row == heights.Length-1 && col == heights[0].Length-1)
            {
                maxValue = Math.Max(maxValue, Math.Abs(heights[row][col] - prev));
                ds.Add(maxValue);
                minV = Math.Min(minV, maxValue);             
                return;
            }
            else if (row < 0 || col < 0 || row >= heights.Length || col >= heights[0].Length)
            {
                return;
            }
            if (row == 0 && col == 0) return;
            if (!visited[row, col])
            {
                visited[row, col] = true;
                maxValue=Math.Max(maxValue, Math.Abs(heights[row][col]-prev));
                prev = heights[row][col];
                helper(heights, row - 1, col, visited,prev, maxValue);
                helper(heights, row, col - 1, visited, prev,maxValue);
                helper(heights, row + 1, col, visited,prev, maxValue);
                helper(heights, row, col + 1, visited, prev, maxValue);
                visited[row, col] = false;
            }
        }
        private int max4(int a, int b, int c, int d)
        {
            int temp = Math.Max(a, b);
            int temp2 = Math.Max(c, d);
            return Math.Max(temp, temp2);
        }
        private int Min(int a, int b, int c, int d)
        {
            return Math.Min(a, Math.Min(b, Math.Min(c, d)));
        }
    }
}
