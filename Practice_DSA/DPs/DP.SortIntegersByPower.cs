using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        public void testCaseForSortByPowerValue()
        {
           // [["X","X","X","X"],["X","O","O","X"],["X","X","O","X"],["X","X","O","X"]]
            Solution solution = new Solution();

            char[][] board = new char[][]
{
               new char[]{'X','X','X','X'},
                 new char[]{'X','O','O','X'},
                 new char[]{'X','X','O','X'},
                   new char[]{'X','X','O','X'}
};
            solution.Solve(board);
            int[][] grid = new int[][]
            {
               new int[]{1,1,1},
               new int[]{1,1,0},
               new int[]{1,0,1}
            };
            string[] arr = new string[] { "1", "3", "5", "7" };
            int n = 985745;
            int lo = 1;
            int hi =100;
            int k = 18;
            int ans =  GetKth(lo, hi, k);
        }
       
        class Cmp : IComparer<Tuple<int, int>>
        {
            public int Compare(Tuple<int, int> a, Tuple<int, int> b)
            {
                if (a.Item2 > b.Item2) return 1;
                else if (a.Item2 < b.Item2) return -1;
                else return 0;
            }
        }
        public int GetKth(int lo, int hi, int k)
        {
            List<Tuple<int, int>> ds = new List<Tuple<int, int>>();
            Cmp cmp = new Cmp();
            for (int i = lo; i <= hi; i++)
            {
                int num = helper(i);
                ds.Add(new Tuple<int, int>(i, num));         
            }
            List<int> result = ds.OrderBy(x => x.Item2).ToList().Select(x => x.Item1).ToList();
            return result[k - 1];
        }
        private int helper(int num)
        {
            if (num <= 1)
                return 0;
            else if (map.ContainsKey(num))
                return map[num];
            if (num % 2 == 0)
            {
                if (!map.ContainsKey(num))
                {
                    int sum = 1 + helper(num/2);
                    map.Add(num, sum);
                }
                return map[num];
            }
            else
            {
                if (!map.ContainsKey(num))
                {
                    int sum = 1 + helper(3 * num + 1);
                    map.Add(num, sum);
                }
                return map[num];
            }

        }
    }
    public class Solution
    {
        public void Solve(char[][] board)
        {
            int col = board[0].Length;
            int row = board.Length;
            bool[,] visited = new bool[row, col];
            //
            //check the boundary land 'O'
            checkBoundaryLastRow(board, ref visited, row, col);
            checkBoundaryFirstRow(board, ref visited, row, col);

            checkBoundaryFirstColumn(board, ref visited, row, col);
            checkBoundaryLastColumn(board, ref visited, row, col);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (visited[i, j]) continue;
                    else if (board[i][j] == 'X') continue;
                    else if (board[i][j] == 'O' && !visited[i, j])
                    {
                        bool isFound = false;
                        dfs(board, i, j, ref visited, ref isFound);
                    }
                }
            }
        }
        private void checkBoundaryFirstRow(char[][] board, ref bool[,] visited, int row, int col)
        {
            int k = 0;
            while (k <= board[0].Length - 1)
            {
                bool isFound = false;
                if (board[0][k] == 'O' && !visited[0, k])
                {
                    dfs(board, row, col, ref visited, ref isFound);
                }
                k++;
            }
        }
        private void checkBoundaryLastRow(char[][] board, ref bool[,] visited, int row, int col)
        {
            int k = 0;
            while (k <= board[0].Length - 1)
            {
                bool isFound = false;
                if (board[row - 1][k] == 'O' && !visited[row - 1, k])
                {
                    dfs(board, row, col, ref visited, ref isFound);
                }
                k++;
            }
        }
        private void checkBoundaryFirstColumn(char[][] board, ref bool[,] visited, int row, int col)
        {
            int k = 0;
            while (k <= board.Length - 1)
            {
                bool isFound = false;
                if (board[k][0] == 'O' && !visited[k, 0])
                {
                    dfs(board, row, col, ref visited, ref isFound);
                }
                k++;
            }
        }
        private void checkBoundaryLastColumn(char[][] board, ref bool[,] visited, int row, int col)
        {
            int k = 0;
            while (k <= board.Length - 1)
            {
                bool isFound = false;
                if (board[k][col - 1] == 'O' && !visited[k, col - 1])
                {
                    dfs(board,k,col-1, ref visited, ref isFound);
                }
                k++;
            }
        }
        private void dfs(char[][] board, int row, int col, ref bool[,] visited, ref bool isFound)
        {
            //edge case 
            if (row < 0 || row >= board.Length || col < 0 || col >= board[0].Length)
                return;

            if (board[row][col] == 'O' && !visited[row, col])
            {
                visited[row, col] = true;
                if (row == 0 || col == 0 || row == board.Length - 1 || col == board[0].Length - 1)
                {
                    isFound = true;
                    dfs(board, row - 1, col, ref visited, ref isFound);
                    dfs(board, row + 1, col, ref visited, ref isFound);
                    dfs(board, row, col - 1, ref visited, ref isFound);
                    dfs(board, row, col + 1, ref visited, ref isFound);
                }
                else
                {
                    if (isFound)
                        board[row][col] = 'O';
                    else if (isFound == false)
                        board[row][col] = 'X';
                    dfs(board, row - 1, col, ref visited, ref isFound);
                    dfs(board, row + 1, col, ref visited, ref isFound);
                    dfs(board, row, col - 1, ref visited, ref isFound);
                    dfs(board, row, col + 1, ref visited, ref isFound);

                }
            }
        }
    }
}
