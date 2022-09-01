using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public void testCaseForIslands()
        {
            char[][] grid = new char[][] {
                      new char[]{'1','1','0','0','0'},
                      new char[]{'1','1','0','0','0'},
                      new char[]{'0','0','1','0','0'},
                      new char[]{'0','0','0','1','1'}
            };
            int[][] gridX = new int[][] {
                      new int[]{1,1,0,0,0},
                      new int[]{1,1,0,0,0},
                      new int[]{0,0,1,0,0},
                      new int[]{0,0,0,1,1}
            };
            int tot = NumIslands(grid);
            int area = MaxAreaOfIsland(gridX);
            //test case 2
            char[][] grid1 = new char[][] {
               new char[]   { '1','1','1','1','0'},
            new char[]  { '1','1','0','1','0'},
              new char[] { '1','1','0','0','0'},
            new char[]  { '0','0','0','0','0'}
            };
            int totl = NumIslands(grid1);
        }
        private int NumIslands(char[][] grid)
        {
            int row = grid.Length;
            int col = grid[0].Length;
            bool[,] visited = new bool[row,col];
            int count = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (visited[i,j] == true)
                    {
                        continue;
                    }
                    else if (IslandSearch(grid,ref visited, i, j))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private bool IslandSearch(char[][]grid,ref bool[,] visited, int r, int c)
        {
           if(r == grid.Length && c == grid[0].Length)
            {
                if( grid[r][c] =='1')
                {
                    return true;
                }
                return false;
            }
           if(r<0 || r>=grid.Length || c<0 || c>=grid[0].Length)
            {
                return false;
            }
            if(grid[r][c] == '1')
            {
                if(!visited[r,c])
                {
                    visited[r,c] = true;
                    //look on left
                    bool Isleft = IslandSearch(grid,ref visited, r, c+1);
                    bool IsBottom = IslandSearch(grid, ref visited, r-1, c);
                    bool Isright = IslandSearch(grid, ref visited, r, c-1);
                    bool IsTop = IslandSearch(grid, ref visited, r + 1, c);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        private int MaxAreaOfIsland(int[][] grid)
        {
            int row = grid.Length;
            int col = grid[0].Length;
            bool[,] visited = new bool[row, col];
            int maxArea = int.MinValue;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int Area = 0;
                    if (visited[i, j] == true)
                    {
                        continue;
                    }
                    else if (IslandSearchMA(grid, ref visited, i, j, ref Area))
                    {
                        maxArea = Math.Max(Area, maxArea);
                    }
                }
            }
            return maxArea;
        }
        private bool IslandSearchMA(int[][] grid, ref bool[,] visited, int r, int c, ref int Area)
        {
            if (r == grid.Length && c == grid[0].Length)
            {
                if (grid[r][c] == 1)
                {
                    return true;
                }
                return false;
            }
            if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length)
            {
                return false;
            }
            if (grid[r][c] == 1)
            {
                if (!visited[r, c])
                {
                    visited[r, c] = true;
                    Area = Area + 1;
                    bool Isleft = IslandSearchMA(grid, ref visited, r, c + 1, ref Area);
                    bool IsBottom = IslandSearchMA(grid, ref visited, r - 1, c, ref Area);
                    bool Isright = IslandSearchMA(grid, ref visited, r, c - 1, ref Area);
                    bool IsTop = IslandSearchMA(grid, ref visited, r + 1, c, ref Area);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
