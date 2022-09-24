using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public void testCaseForValidSoduko()
        {
            char[][] matrix= new char[][]{
            new char[]{'5','3','.','.','7','.','.','.','.'},
            new char[]{'6','.','.','1','9','5','.','.','.'},
            new char[]{'.','9','8','.','.','.','.','6','.'},
            new char[]{'8','.','.','.','6','.','.','.','3'},
            new char[]{'4','.','.','8','.','3','.','.','1'},
            new char[]{'7','.','.','.','2','.','.','.','6'},
            new char[]{'.','6','.','.','.','.','2','8','.'},
            new char[]{'.','.','.','4','1','9','.','.','5'},
            new char[]{'.','.','.','.','8','.','.','7','9'}};
            bool isValid = IsValidSudoku(matrix);
        }
        public bool IsValidSudoku(char[][] board)
        {
            bool checkSmallGrid = false;
            for (int i = 0; i <= board.Length - 2; i = i + 3)
            {
                for (int j = 0; j <= board[0].Length - 2; j = j + 3)
                {
                    checkSmallGrid = checkSubGrid(board, i, j);
                    if (!checkSmallGrid) return false;
                }
            }
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    bool checkRight = checkRightSide(board, i, j);
                    bool checkBottom = checkBottomSide(board, i, j);
                    bool isValid = checkRight && checkBottom && checkSmallGrid;
                    if (!isValid) return false;
                }
            }
            return true;
        }
        private bool checkRightSide(char[][] board, int i, int j)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int m = i; m < 9; m++)
            {
                if (board[m][j] == '.') continue;
                else if (map.ContainsKey(board[m][j])) return false;
                map.Add(board[m][j], 1);
            }
            return true;
        }
        private bool checkBottomSide(char[][] board, int i, int j)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int m = j; m < 9; m++)
            {
                if (board[i][m] == '.') continue;
                else if (map.ContainsKey(board[i][m])) return false;
                map.Add(board[i][m], 1);
            }
            return true;
        }

        private bool checkSubGrid(char[][] board, int i, int j)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int m = i; m < 3 + i; m++)
            {
                for (int n = j; n < 3 + j; n++)
                {
                    char element = board[m][n];
                    if (element == '.') continue;
                    if (map.ContainsKey(element))
                        return false;
                    map.Add(element, 1);
                }
            }
            return true;
        }
    }
}
