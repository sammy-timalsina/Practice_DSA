using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial  class DP
    {
        public int LongestCommonSubStringIter(string text1, string text2)
        {
            int[,] dp = new int[text1.Length + 1, text2.Length + 1];
            int count = 0;
            for (int i = 0; i <= text1.Length; i++)
            {
                for (int j = 0; j <= text2.Length; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                    }
                    else
                    {
                        if (text1[i - 1] == text2[j - 1])
                        {
                            dp[i,j] = 1 + dp[i - 1, j - 1];
                            count = Math.Max(count, dp[i, j]);
                        }
                        else
                        {
                            dp[i, j] = 0;
                        }
                    }
                }
            }
            return count;
        }
        public string LCSubStringIter(string text1, string text2)
        {
            string [,] dp = new string[text1.Length, text2.Length];
            string  str =string.Empty;
            for (int i = 1; i < text1.Length; i++)
            {
                for (int j = 1; j < text2.Length; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + text1[i - 1];
                        if (dp[i, j].Length >= str.Length)
                        {
                            if (IsPalindrome(dp[i, j]))
                            {
                                str = dp[i, j];
                            }
                        }
                    }
                    else
                    {
                        dp[i, j] = string.Empty;
                    }

                }
            }
            return str;
        }

        private bool IsPalindrome(string v)
        {
            int i= 0;
            int j = v.Length - 1;
            while(i<v.Length-1)
            {
                if(v[i]!=v[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
