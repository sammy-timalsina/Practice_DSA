using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public bool Exist(char[][] board, string word)
        {
            //https://leetcode.com/problems/word-search/discuss/2511584/C-solution-using-recursion-and-backtracking
            bool game = false;
            int row = board.Length;
            int col = board[0].Length;
            bool[,] vs = new bool[row, col];

            for (int i = 0; i < board.Length; i++)
                for (int j = 0; j < board[i].Length; j++)
                {
                    for (int ii = 0; ii < row; ii++)
                        for (int jj = 0; jj < col; jj++)
                            vs[ii, jj] = false;
                    if (Helper(board, i, j, 0, word, vs))
                    {
                        game = true;
                        break;
                    }
                }
            return game;
        }
        private bool Helper(char[][] board, int r, int c, int k, string word, bool[,] visited)
        {
            if (k >= word.Length)
            {
                return true;
            }
            if (r < 0 || r >= board.Length)
            {
                return false;
            }
            if (c < 0 || c >= board[0].Length)
            {
                return false;
            }
            //
            if (board[r][c] == word[k])
            {

                if (!visited[r, c])
                {
                    visited[r, c] = true;
                    bool firstPart = Helper(board, r + 1, c, k + 1, word, visited);
                    bool secondPart = Helper(board, r, c + 1, k + 1, word, visited);
                    bool thirdPart = Helper(board, r - 1, c, k + 1, word, visited);
                    bool fourthPart = Helper(board, r, c - 1, k + 1, word, visited);
                    bool ans = firstPart || secondPart || thirdPart || fourthPart;
                    visited[r, c] = false;
                    return ans;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
