using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public void testCaseForLargestRectangleArea()
        {

            int[] heights = new int[] { 2, 1, 5, 6, 2, 2,2,2,2,2,3 };
            LargestRectangleArea(heights);
        }
        public int LargestRectangleArea(int[] heights)
        {
            int [] dp = new int[heights.Length];
            int j = heights.Length-2;
            int area = 0;
            int area2 = 0;
            int area3 = 0;
            int minHt = heights[j+1];
            dp[j+1] = minHt;
            while(j>=0)
            {
                minHt = Math.Min(heights[j], heights[j+1]);
                area =1*heights[j];
                area2 = 2 * minHt;
                area3 = Math.Max(area, area2) + dp[j + 1];
                dp[j] = Math.Max(area,Math.Max(area3,dp[j+1]));
                j--;
            }
            return dp[0];
        }
    }
}
