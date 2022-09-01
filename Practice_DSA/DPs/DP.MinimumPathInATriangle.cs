using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public void minTotalInAtriangle()
        {
            IList<IList<int>> ip = new List<IList<int>>();
            //List<int> ip0 = new List<int>() { -1 };
            //List<int> ip1 = new List<int>() { 2, 3 };
            //List<int> ip2 = new List<int>() { 1, -1, -3 };
            List<int> ip0 = new List<int>() { 2 };
            List<int> ip1 = new List<int>() { 3, 4 };
            List<int> ip2 = new List<int>() { 6, 5, 7 };
            List<int> ip3 = new List<int>() { 4, 1, 8, 3 };
            ip.Add(ip0);
            ip.Add(ip1);
            ip.Add(ip2);
            ip.Add(ip3);
           MinimumTotal(ip);
        }
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            //Input: triangle = [[2],[3,4],[6,5,7],[4,1,8,3]]
            //Output: 11
            //Explanation: The triangle looks like:
            //   2
            //  3 4
            // 6 5 7
            //4 1 8 3
            //The minimum path sum from top to bottom is 2 + 3 + 5 + 1 = 11(underlined above).
            int[,] dp = new int[triangle.Count, triangle.Count];
            //initialize first row of dp

            int min = int.MaxValue;
            for(int i=0;i<triangle.Count;i++)
            {
                for (int j=0;j<triangle[i].Count;j++)
                {
                    if (i == 0 && j == 0)
                    {
                        dp[i, j] = triangle[i][j];
                    }
                    else if (j == 0)
                    {
                        dp[i, j] = triangle[i][j] + dp[i - 1, j];
                    }
                    else if(j == triangle[i].Count -1)
                    {
                        dp[i, j] = triangle[i][j] + dp[i - 1, j - 1];
                    }
                    else if(i>0 && j<triangle[i].Count-1)
                    {
                        dp[i, j] = triangle[i][j] + Math.Min(dp[i-1,j], dp[i - 1,j - 1]);
                    }
                }
            }
            for(int i = 0; i< triangle.Count;i++)
            {
               min = Math.Min(min, dp[triangle.Count-1,i]);
            }
            return min;
        }
        int MinimumTotal(IList<IList<int>> triangle, int rc, int cc)
        {
            if(rc == triangle.Count || cc == triangle[rc].Count)
            {
                return 0;
            }
            int minm = 0;
            minm = Math.Max(triangle[rc][cc]+MinimumTotal(triangle, rc + 1, cc),
               triangle[rc][cc+1] + MinimumTotal(triangle, rc + 1, cc + 1));

            return minm;

        }
    }
}
