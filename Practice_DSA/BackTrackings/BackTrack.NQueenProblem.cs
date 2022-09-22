using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        List<string> path = new List<string>();
        IList<IList<string>> QueenPositions = new List<IList<string>>();
        long totalSolutions = 0;
        bool IsQueenFound = false;
        int colPosition = 0;
        public void testcaseForNQueen()
        {
            //MySolution for nQueen problem
            //leet code
            //https://leetcode.com/submissions/detail/805660007/
            //https://leetcode.com/submissions/detail/805662486/
            //Grid Illumination https://leetcode.com/problems/grid-illumination/
            int n = 13;
            int[,] chessBoard = new int[n, n];
            int row = chessBoard.GetLength(0);
            int col = chessBoard.GetLength(1);
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    chessBoard[i, j] = 0;
         
            noOfNQueensPossible(row, col,chessBoard);
        }
        private void noOfNQueensPossible(int m, int n, int[,] chessBoard)
        {
            bool[] visitedRow = new bool[m];
            bool[] visitedColumn = new bool[n];
            int[,] visitedDiagonal = new int[m, n];
            dfs(chessBoard, 0, visitedRow, visitedColumn, ref visitedDiagonal);
        }
        private void dfs(int[,]chessBoard,int row, bool[] visitedRow, bool[] visitedColumn,ref int[,]visitedDiagonal)
        {
            int rowSize = chessBoard.GetLength(0);
            int colSize = chessBoard.GetLength(1);
            if (row >= rowSize)
            {
                if (IsQueenFound && chessBoard[rowSize - 1, colPosition] == 1)
                {
                    totalSolutions++;
                    for (int m = 0; m < rowSize; m++)
                    {
                        string s = string.Empty;
                        for (int j = 0; j < colSize; j++)
                        {
                            if (chessBoard[m, j] == 1)
                            {
                                s = s + "Q";
                                continue;
                            }
                            s = s + " " + "_" + " ";
                        }
                        path.Add(s);
                    }
                    QueenPositions.Add(new List<string>(path));
                    path.Clear();
                    IsQueenFound = false;
                    colPosition = 0;
                    return;
                }
            }
            for(int i= 0; i<colSize;i++)
            {
                bool InValidPath = visitedRow[row] || visitedColumn[i] || visitedDiagonal[row, i] > 0;
                if(!InValidPath)
                {
                    visitedRow[row] = true;
                    visitedColumn[i] = true;
                    markRightDiagonalCells(row, i, ref visitedDiagonal);
                    markLeftDiagonalCells(row, i, ref visitedDiagonal);
                    chessBoard[row, i] = 1;
                    if(chessBoard[rowSize-1, i] == 1)
                    {
                        IsQueenFound = true;
                        colPosition = i;
                    }
                    dfs(chessBoard, row + 1, visitedRow, visitedColumn, ref visitedDiagonal);
                    chessBoard[row, i] = 0;
                    visitedRow[row] = false;
                    visitedColumn[i] = false;
                    unmarkRightDiagonalCells(row, i, ref visitedDiagonal);
                    unmarkLeftDiagonalCells(row, i, ref visitedDiagonal);
                }
            }
        }
        private void unmarkRightDiagonalCells(int row, int col, ref int[,] visitedDiagonal )
        {
            int rowSize = visitedDiagonal.GetLength(0);
            int colSize = visitedDiagonal.GetLength(1);
            if (row >= rowSize || col >= colSize) return;
            visitedDiagonal[row, col]--;
            unmarkRightDiagonalCells(row+1,col+1, ref visitedDiagonal);  
        }
        private void markRightDiagonalCells(int row, int col, ref int[,] visitedDiagonal)
        {
            int rowSize = visitedDiagonal.GetLength(0);
            int colSize = visitedDiagonal.GetLength(1);
            if (row >= rowSize || col >= colSize) return;
            visitedDiagonal[row, col]++;
            markRightDiagonalCells(row + 1, col + 1, ref visitedDiagonal);
        }
        private void unmarkLeftDiagonalCells(int row, int col, ref int[,] visitedDiagonal)
        {

            if (row >= visitedDiagonal.GetLength(0) || col < 0) return;
            visitedDiagonal[row, col]--;
            unmarkLeftDiagonalCells(row + 1, col - 1, ref visitedDiagonal);
        }
        private void markLeftDiagonalCells(int row, int col, ref int[,] visitedDiagonal)
        {
            int len = visitedDiagonal.GetLength(0);
            if (row >= len || col < 0) return;
            visitedDiagonal[row, col]++;
            markLeftDiagonalCells(row + 1, col - 1, ref visitedDiagonal);
        }

    }
}
