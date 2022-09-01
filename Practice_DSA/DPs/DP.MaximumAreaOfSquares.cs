using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public void FindMaxiumSquares()
        {
            //[["1","1","1","1","1"],
            //["1","1","1","1","1"],
            //["0","0","0","0","0"],
            //["1","1","1","1","1"],["1","1","1","1","1"]]
            //: matrix = [["0","1"],["1","0"]] op = 9 expected 4
            char[][] mmat = new char[][]
            {
                new char[]{'0','1'},
                new char[]{'1','0'}
            };
            char[][] mat = new char[][]
                  {
                                new char[]{'1','1','1','1','0'},
                                new char[]{'1','1','1','1','1'},
                                new char[]{'0','0','0','0','0'},
                                new char[]{'1','1','1','1','1'},
                                 new char[]{'1','1','1','1','1'}
                  };
            int totSquares = MaximalSquare(mat);
        }
        int MaximalSquare(char[][] matrix)
        {
            int row = matrix.Length;
            int col = matrix[0].Length;
            int[,] dp = new int[row,col];
            int max = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        if(matrix[i][j] == '1')
                        { 
                            dp[i,j] = 1; 
                        }
                        else
                        {
                            dp[i, j] = 0;
                        }
                    }
                    else
                    {
                        if (matrix[i][j] == '0')
                        {
                            dp[i, j] = 0;
                        }
                        else
                        {
                            dp[i, j] = 1 + Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1]));
                        }
           
                    }
                    max = Math.Max(dp[i, j], max);
                }
            }
            return max * max;
        }
    }
}
