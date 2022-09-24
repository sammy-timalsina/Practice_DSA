using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public void testCaseForPAcificAtlantic()
        {
            int[][] heights = new int[][]
            {
                new int[]{1,2,2,3,5},
                new int[]{2,200,3,4,4},
                new int[]{2,4,5,3,1},
                new int[]{6,7,100,4,5 },
                new int[]{5,1,1,2,4 }
            };
            var ans = PacificAtlantic(heights);
        }
        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            for (int i = 0; i < heights.Length; i++)
            {
                for (int j = 0; j < heights[0].Length; j++)
                {
                    bool[,] visited = new bool[heights.Length, heights[0].Length];
                    bool isPacificFlow = false;
                    bool isAtlanticFlow = false;
                    checkPacific(heights, i, j, heights[i][j], ref isPacificFlow, visited);
                    visited = new bool[heights.Length, heights[0].Length];
                    checkAtlantic(heights, i, j, heights[i][j], ref isAtlanticFlow, visited);
                    bool isValidCell = isPacificFlow && isAtlanticFlow;
                    if (isValidCell)
                    {
                        ans.Add(new List<int>() { i, j });
                    }
                }
            }
            return ans;
        }
        private void checkPacific(int[][] heights, int row, int col, int cell, ref bool isPacificFlow, bool[,] visited)
        {
            if (row < 0 || col < 0)
            {
                isPacificFlow = true;
                return;
            }
            else if (row >= heights.Length || col >= heights[0].Length) return;
            else if (isPacificFlow) return;
            else if (heights[row][col] > cell) isPacificFlow = false;
            else if (!visited[row, col])
            {
                visited[row, col] = true;
                checkPacific(heights, row - 1, col, heights[row][col], ref isPacificFlow, visited);
                checkPacific(heights, row, col - 1, heights[row][col], ref isPacificFlow, visited);
                checkPacific(heights, row + 1, col, heights[row][col], ref isPacificFlow, visited);
                checkPacific(heights, row, col + 1, heights[row][col], ref isPacificFlow, visited);
            }
        }
        private void checkAtlantic(int[][] heights, int row, int col, int cell, ref bool isAtlanticFlow, bool[,] visited)
        {
            if (row >= heights.Length || col >= heights[0].Length)
            {
                isAtlanticFlow = true;
                return;
            }
            else if (row < 0 || col < 0) return;
            else if (isAtlanticFlow) return;
            else if (heights[row][col] > cell) isAtlanticFlow = false;
            else if (!visited[row, col])
            {
                visited[row, col] = true;
                checkAtlantic(heights, row, col + 1, heights[row][col], ref isAtlanticFlow, visited);
                checkAtlantic(heights, row + 1, col, heights[row][col], ref isAtlanticFlow, visited);
                checkAtlantic(heights, row - 1, col, heights[row][col], ref isAtlanticFlow, visited);
                checkAtlantic(heights, row, col - 1, heights[row][col], ref isAtlanticFlow, visited);
            }
        }
    }
}
