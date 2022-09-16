using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public void GameOfLife(int[][] board)
        {
            
            int row = board.Length;
            int col = board[0].Length;
            if (row == 1 && col == 1)
            {
                board[0][0] = 0;
                return;
            }           
            int[,] tempBoard = new int [row, col];
            bool[,] visited = new bool[row, col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    tempBoard[i, j] = board[i][j];
            if (row == 1)
            {
                dfsRow1(ref board, tempBoard);
            }
            else if (col==1)
            {
                dfsCol1(ref board, tempBoard);
            }
            else
            {
                dfs(0, 0, ref board, tempBoard, visited);
            }
        }
        private void dfsCol1(ref int[][] board, int[,]tempBoard)
        {
            int currentLiveCells = 0;
            for (int r = 0; r < board.Length; r++)
            {
                if (r == 0)
                {
                    currentLiveCells = tempBoard[ r + 1,0];
                }
                else if (r == board.Length - 1)
                {
                    currentLiveCells = tempBoard[r - 1,0];
                }
                else
                {
                    currentLiveCells = tempBoard[ r + 1,0] + tempBoard[ r - 1,0];
                }
                if (tempBoard[ r,0] == 1)
                {
                    if (currentLiveCells < 2)
                    {
                        board[r][0] = 0;
                    }
                    else if (currentLiveCells == 2 || currentLiveCells == 3)
                    {
                        board[r][0] = 1;
                    }
                }
            }
        }
        private void dfsRow1( ref int[][] board, int[,] tempBoard)
        {
            int currentLiveCells = 0;
          for(int r=0;r<board[0].Length;r++)
            {
                if (r == 0)
                {
                    currentLiveCells = tempBoard[0, r + 1];
                }
                else if (r == board[0].Length - 1)
                {
                    currentLiveCells = tempBoard[0, r - 1];
                }
                else
                {
                    currentLiveCells = tempBoard[0, r + 1] + tempBoard[0, r - 1];
                }
                if (tempBoard[0, r] == 1)
                {
                    if (currentLiveCells < 2)
                    {
                        board[0][r] = 0;
                    }
                    else if (currentLiveCells == 2 || currentLiveCells == 3)
                    {
                        board[0][r] = 1;
                    }
                }
            }
        }
        private void dfs(int i, int j, ref int[][] board, int[,] tempBoard, bool[,] visited)
        {
            //base case
            if (i < 0 || j < 0 || i >= board.Length || j >= board[0].Length)
                return;
            int currentLiveCells = 0;
            //look up
            if (visited[i, j])
                return;
            visited[i, j] = true;
            if (i == 0 && j == 0)
            {
                //if there is a row below
                currentLiveCells = tempBoard[i + 1, j] + tempBoard[i, j + 1] + tempBoard[i + 1, j + 1];


            }
            else if (i == 0 && j < board[0].Length - 1)
            {
                currentLiveCells = tempBoard[i + 1, j] + tempBoard[i, j + 1] + tempBoard[i + 1, j + 1] +
                                   tempBoard[i + 1, j - 1] + tempBoard[i, j - 1];

            }
            else if (i == 0 && j == board[0].Length - 1)
            {

                currentLiveCells = tempBoard[i, j - 1] + tempBoard[i + 1, j - 1] + tempBoard[i + 1, j];
            }
            else if (i == board.Length - 1 && j == 0)
            {
                currentLiveCells = tempBoard[i - 1, j] + tempBoard[i - 1, j + 1] + tempBoard[i, j + 1];
            }
            else if (i == board.Length - 1 && j < board[0].Length - 1)
            {
                currentLiveCells = tempBoard[i - 1, j] + tempBoard[i - 1, j - 1] + tempBoard[i - 1, j + 1] +
                                   tempBoard[i, j - 1] + tempBoard[i, j + 1];
            }
            else if (i == board.Length - 1 && j == board[0].Length - 1)
            {
                currentLiveCells = tempBoard[i - 1, j] + tempBoard[i - 1, j - 1] + tempBoard[i, j - 1];
            }
            else if (j == 0 && i != 0)
            {
                currentLiveCells = tempBoard[i - 1, j] + tempBoard[i - 1, j + 1] + tempBoard[i, j + 1] +
                                   tempBoard[i + 1, j] + tempBoard[i + 1, j + 1];
            }
            else if (j == board[0].Length - 1 && i != 0)
            {
                currentLiveCells = tempBoard[i - 1, j] + tempBoard[i - 1, j - 1] + tempBoard[i, j - 1] +
                                     tempBoard[i + 1, j] + tempBoard[i + 1, j - 1];
            }
            else
            {
                currentLiveCells = tempBoard[i - 1, j] + tempBoard[i + 1, j] +
                    tempBoard[i, j - 1] + tempBoard[i, j + 1] +
                    tempBoard[i - 1, j - 1] + tempBoard[i - 1, j + 1] +
                    tempBoard[i + 1, j - 1] + tempBoard[i + 1, j + 1];
            }
            //apply rules now
            if (tempBoard[i, j] == 0)
            {
                if (currentLiveCells == 3)
                {
                    board[i][j] = 1;
                }
            }
            else if (currentLiveCells < 2)
            {
                board[i][j] = 0;
            }
            else if (currentLiveCells == 2 || currentLiveCells == 3)
            {
                board[i][j] = 1;
            }
            else if (currentLiveCells > 3)
            {
                board[i][j] = 0;
            }
            dfs(i - 1, j, ref board, tempBoard, visited);
            dfs(i + 1, j, ref board, tempBoard, visited);
            dfs(i, j - 1, ref board, tempBoard, visited);
            dfs(i, j + 1, ref board, tempBoard, visited);
            dfs(i - 1, j - 1, ref board, tempBoard, visited);
            dfs(i - 1, j + 1, ref board, tempBoard, visited);
            dfs(i + 1, j - 1, ref board, tempBoard, visited);
            dfs(i + 1, j + 1, ref board, tempBoard, visited);
        }
    }
}
