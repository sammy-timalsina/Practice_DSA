using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public void testCaseForFindWords()
        {
            //test case 1
            // Input: board = [["o", "a", "a", "n"],["e","t","a","e"],["i","h","k","r"],["i","f","l","v"]],
            // words = ["oath", "pea", "eat", "rain"]
            //Output:["eat","oath"]
            char[][] ch = new char[][] {
                new char[] {'o','a','a','n' },
                new char[] {'e','t','a','e' },
                new char[] {'i','h','k','r' },
                new char[] {'i','f','l','v'}
            };
            string[] words = new string[] { "oath", "pea", "eat", "rain" };
            IList<string> list = FindWords(ch, words);
            //test case 2
            //Input: board = [["a","b"],["c","d"]], words = ["abcb"]
            // Output:[]
            char[][] ch1 = new char[][] {
                new char[] {'a','b' },
                new char[] {'c','d' }
            };
            string[] word2 = new string[] { "abcb" };
            IList<string> list2 = FindWords(ch1, word2);

            //test case 3
            char[][] ch3 = new char[][] {
                    new char[] { 'm', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l' },
                    new char[]{ 'n', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
                    new char[] { 'o', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
                    new char[]{ 'p', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
                    new char[]{ 'q', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
                    new char[]{ 'r', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
                    new char[]{ 's', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
                    new char[]{ 't', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
                    new char[]{ 'u', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
                    new char[]{ 'v', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
                    new char[]{ 'w', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' },
                    new char[]{ 'x', 'y', 'z', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' }
            };
            string[] word3 = getBigStringArray();
            IList<string> list3 = FindWords(ch3, word3);
        }

        public IList<string> FindWords(char[][] board, string[] words)
        {
            //https://leetcode.com/problems/word-search-ii/
            List<string> result = new List<string>();
            int row = board.Length;
            int col = board[0].Length;
            bool[,] vs = new bool[row, col];
   
            for (int l = 0; l < words.Length; l++)
            {
              
                bool game = false;
                for (int i = 0; i < board.Length; i++)
                {
                    for (int j = 0; j < board[i].Length; j++)
                    {
                       
                        if (WordSearchHelper(board, i, j, 0, words[l], vs))
                        {
                            game = true;
                            break;
                        }
                    }
                }
                if (game)
                {
                    result.Add(words[l]);
                }
            }
            return result;
        }
        private bool WordSearchHelper(char[][] board, int r, int c, int k, string word, bool[,] visited)
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
            if (board[r][c] == word[k])
            {

                if (!visited[r, c])
                {
                    visited[r, c] = true;
                    bool firstPart = WordSearchHelper(board, r + 1, c, k + 1, word, visited);
                    bool secondPart = WordSearchHelper(board, r, c + 1, k + 1, word, visited);
                    bool thirdPart = WordSearchHelper(board, r - 1, c, k + 1, word, visited);
                    bool fourthPart = WordSearchHelper(board, r, c - 1, k + 1, word, visited);
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
