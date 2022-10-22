using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        int LP = (int)-1E9;
        int currCol = 0;
        int currRow = 0;
        public void testCaseForLongestIncreaingPath()
        {
            int[][] matrix = new int[][]
            {
                new int[]{3,4,5},
                new int[]{2,2,6},
                new int[]{2,2,1}
            };
            int ans = LongestIncreasingPath(matrix);
            //matrix = [[9,9,4],[6,6,8],[2,1,1]]
            LP = (int)-1E9;
            int[][] matrix1 = new int[][]
{
                new int[]{9,9,4},
                new int[]{6,6,8},
                new int[]{2,1,1}
};
            int ans1 = LongestIncreasingPath(matrix1);
        }
        public int LongestIncreasingPath(int[][] matrix)
        {

            int row = matrix.Length;
            int col = matrix[0].Length;
            bool[,] visited = new bool[row, col];
            int[,] result = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    currRow = i; currCol = j;
                    if (visited[i, j]) continue;
                    helper1(matrix, i, j, matrix[i][j], visited, result);
                }
            }
            return LP;
        }
        private int helper1(int[][] matrix, int r, int c, int cell, bool[,] visited, int[,] result)
        {
            if (r < 0 || c < 0 || r >= matrix.Length || c >= matrix[0].Length)
            {
                return 0;
            }
            else if (matrix[r][c] <= cell && !(r == currRow && c == currCol))
            {
                return 0;
            }
            else if (visited[r, c])
            {
                return result[r, c];
            }
            visited[r, c] = true;
            int element = matrix[r][c];
            int right = helper1(matrix, r, c + 1, element, visited, result);
            int left = helper1(matrix, r, c - 1, element, visited, result);
            int up = helper1(matrix, r - 1, c, element, visited, result);
            int down = helper1(matrix, r + 1, c, element, visited, result);
            result[r, c] =  1+Math.Max(right, Math.Max(left, Math.Max(up, down)));
            LP = Math.Max(result[r, c], LP);
            return result[r, c];
        }
    }
}
