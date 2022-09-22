using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        //int cost = 0;
        int currMax = int.MaxValue;
        List<int> ls = new List<int>();
        public void testCaseForHomeComingRobot()
        {
            //        Input: startPos = [1, 0], homePos = [2, 3], rowCosts = [5, 4, 3], colCosts = [8, 2, 6, 7]
            //Output: 18
            int[] startPos = new int[] { 1, 0 };
            int[] homePos = new int[] { 2, 3 };
            int[] rowCosts = new int[] { 5, 4, 3 };
            int[] colCosts = new int[] { 8, 2, 6, 7 };
            int ans = MinCost(startPos, homePos, rowCosts, colCosts);

        }
        public int MinCost(int[] startPos, int[] homePos, int[] rowCosts, int[] colCosts)
        {
            int row = rowCosts.Length;
            int col = colCosts.Length;  
            bool[,] visited = new bool[row,col];
            int cost = 0;
            List<Tuple<int,int>> list = new List<Tuple<int,int>>();
            List<List<Tuple<int,int>>> vector = new List<List<Tuple<int,int>>>();
           // MinCost(startPos, homePos, rowCosts, colCosts,startPos[0],startPos[1], visited, list, vector, 0);
            return 0;
        }

             
        private int min(int a, int b, int c, int d)
        {
            return Math.Min(a, Math.Min(b, Math.Min(c, d)));
        }
    }
}
