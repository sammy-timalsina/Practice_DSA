using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int[,] dp = new int[text1.Length, text2.Length];
            for (int i = 0; i < text1.Length; i++)
            {
                for (int j = 0; j < text2.Length; j++)
                {
                    dp[i, j] = -1;
                }
            }
            return LongestCommonSubsequence(text1, text2, text1.Length-1, text2.Length-1, dp);
        }
        private int LongestCommonSubsequenceIter(string text1, string text2)
        {
            int[,] dp = new int[text1.Length+1, text2.Length+1];
            for (int i = 0; i <= text1.Length; i++)
            {
                for (int j = 0; j <= text2.Length; j++)
                {
                    if(i ==0 || j==0)
                    {
                        dp[i, j] = 0;
                    }
                   else
                    {
                        if(text1[i-1] == text2[j-1])
                        {
                            dp[i, j] = 1 + dp[i - 1, j - 1];
                        }
                        else
                        {
                            dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                        }
                    }
                }
            }
            return dp[text1.Length, text2.Length];
        }
        private int LongestCommonSubsequence(string s1, string s2, int ind1, int ind2, int[,] dp)
        {
            if(ind1 < 0 || ind2< 0)
            {
                return 0;
            }
            if (dp[ind1, ind2] != -1)
            {
                return dp[ind1, ind2];
            }
            if (s1[ind1] == s2[ind2])
            {
                dp[ind1, ind2] = 1 + LongestCommonSubsequence(s1, s2, ind1 - 1, ind2 - 1, dp);
            }
            else
            {
                dp[ind1, ind2] = Math.Max(LongestCommonSubsequence(s1, s2, ind1 - 1, ind2, dp), LongestCommonSubsequence(s1, s2, ind1, ind2 - 1, dp));
            }
            return dp[ind1, ind2];
        }
    }
}
