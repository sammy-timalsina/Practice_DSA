using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public string LongestPalindrome(string s)
        {
            string ps2 = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                ps2 = ps2 + s[i];
            }
            return LCS(s, ps2);
        }
        private string LCS(string s1, string s2)
        {
            string[,] dp = new string[s1.Length + 1, s2.Length + 1];
            for (int i = 0; i <= s1.Length; i++)
            {
                for (int j = 0; j <= s2.Length; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = "";
                    }
                    else
                    {
                        if (s1[i - 1] == s2[j - 1])
                        {
                            dp[i, j] = dp[i - 1, j - 1] + s1[i - 1];
                        }
                        else
                        {
                            if (dp[i - 1, j].Length > dp[i, j - 1].Length)
                            {
                                dp[i, j] = dp[i - 1, j];
                            }
                            else
                            {
                                dp[i, j] = dp[i, j - 1];
                            }

                        }
                    }
                }
            }
            return dp[s1.Length, s2.Length];
        }
    }
}
