using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Graphs
{
    public partial class Graph
    {
        public void testCaseFOrColorBorder()
        {
           int[][] grid = new int[][]
            {
                new int[]{1,2,1,2,1,2},
                new int[]{2,2,2,2,1,2},
                new int[]{1,2,2,2,1,3}
            };
            var ans = ColorBorder(grid, 1, 3, 1);
        }
            public int[][] ColorBorder(int[][] grid, int row, int col, int color)
            {

                int r = grid.Length;
                int c = grid[0].Length;
                int givenColor = grid[row][col];
                bool[,] visited = new bool[r, c];
                int[][] finalGrid = new int[r][];
                for (int i = 0; i < r; i++)
                    finalGrid[i] = new int[c];

                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                        finalGrid[i][j] = grid[i][j];
                }
                dfs(grid, row, col, givenColor, color, visited);
                void dfs(int[][] grid, int row, int col, int givenColor, int color, bool[,] visited)
                {
                    if (row < 0 || col < 0 || row >= r || col >= c) return;
                    if (grid[row][col] == givenColor && !visited[row, col])
                    {
                        visited[row, col] = true;
                        if ((row == 0 || col == 0 || row == r - 1 || col == c - 1))
                        {
                            finalGrid[row][col] = color;
                        }
                        else if (row - 1 >= 0 && !(grid[row - 1][col] == givenColor))
                            finalGrid[row][col] = color;
                        else if (row + 1 <= r - 1 && !(grid[row + 1][col] == givenColor))
                            finalGrid[row][col] = color;
                        else if (col - 1 >= 0 && !(grid[row][col - 1] == givenColor))
                            finalGrid[row][col] = color;
                        else if (col + 1 <= c - 1 && !(grid[row][col + 1] == givenColor))
                            finalGrid[row][col] = color;

                        dfs(grid, row - 1, col, givenColor, color, visited);
                        dfs(grid, row + 1, col, givenColor, color, visited);
                        dfs(grid, row, col - 1, givenColor, color, visited);
                        dfs(grid, row, col + 1, givenColor, color, visited);
                    }
                }
                return finalGrid;
            }
        
    }
}
