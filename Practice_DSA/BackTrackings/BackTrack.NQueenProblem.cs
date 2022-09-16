using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public void testcaseForNQueen()
        {
           
            int[,] chessBoard = new int[4, 4];
            int row = chessBoard.GetLength(0);
            int col = chessBoard.GetLength(1);
            //0 => visited
            //1=> queen
            //-1=>not visited
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    chessBoard[i, j] = 0;
            noOfNQueensPossible(row, col,chessBoard);
        }
        private void noOfNQueensPossible(int m, int n, int[,] chessBoard)
        {

        }
        private void dfs(int i, int j,int[,] chessBoard)
        {
            int tempi = i;
            int tempj = j;
            while (j < chessBoard.GetLength(1))
            {
                chessBoard[i, j] = 1;
                j++;
            }
            j = tempj;
            while (j >= 0 && j<chessBoard.GetLength(1))
            {
                chessBoard[i, j] = 1;
                j--;
            }
            j = tempj;
            while (i < chessBoard.GetLength(0))
            {
                chessBoard[i, j] = 1;
                i++;
            }
            i = tempi;
            while(i >= 0 && i<chessBoard.GetLength(0))
            {
                chessBoard[i, j] = 1;
                i--;
            }
            i = tempi;
            while(i<chessBoard.GetLength(0) && j<chessBoard.GetLength(1))
            {
                chessBoard[i, j] = 1;
                i++;j++;
            }
            i = tempi;
            j = tempj;
            while(i<chessBoard.GetLength(0) && j>=0)
            {
                chessBoard[i, j] = 1;
                i++; j--;

            }
        }
        private bool IsUp(int i,int j,  int[,] chessBoard)
        {
            if(i<0)
                return false;
            bool IsQueen=false;
            if(chessBoard[i,j] == 1)
            {
               IsQueen=true;
                return IsQueen;
            }
            return IsQueen || IsUp(i-1,j, chessBoard);
        }
        private bool IsLeftDiagonal(int i, int j,  int[,] chessBoard)
        {
            if (i < 0 || j < 0)
                return false;
            bool IsQueen = false;
            if(chessBoard[i,j]==1)
            {
                IsQueen = true;
                return IsQueen;
            }
            return IsQueen||IsLeftDiagonal(i-1,j-1,chessBoard);
        }
        private bool IsRightDiagonal(int i, int j, int[,] chessBoard)
        {
            if (i < 0 || j >= chessBoard.GetLength(1))
                return false;
            bool IsQueen = false;
            if (chessBoard[i, j] == 1)
            {
                IsQueen = true;
                return IsQueen;
            }
            return IsQueen||IsRightDiagonal(i - 1, j + 1,chessBoard);
        }
    }
    public class State
    {
        public int stateI;
        public int stateJ;
        public State(int m, int n)
        {
           stateI = m;
            stateJ = n;
        }
    }
}
