using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public void testCaseForMinDistance()
        {
            //            Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.

            //You have the following three operations permitted on a word:

            //    Insert a character
            //    Delete a character
            //    Replace a character


                //        Input: word1 = "horse", word2 = "ros"
                //Output: 3
                //Explanation:
                //            horse->rorse(replace 'h' with 'r')
                //rorse->rose(remove 'r')
                //rose->ros(remove 'e')
        }
        public int MinDistance(string word1, string word2)
        {
            int[,] dp = new int[word1.Length,word2.Length];
            for (int i = 0; i < word1.Length; i++)
                for (int j = 0; j < word2.Length; j++)
                    dp[i, j] = -1;
            int ans =  del(word1,word2,word1.Length-1,word2.Length-1,dp);
            return ans; 
        }
   
        private int del(string word1, string word2 , int i1, int i2,int[,]dp)
        {
            if(i1 == 0 && i2 == 0)
            {
                dp[i1, i2] = 1;
                return 1;
            }
            else if(i1 < 0)
            {
                return i2+1;
            }
            else if(i2<0)
            {
                return i1 + 1;
            }
            else if(dp[i1,i2]!=-1) return dp[i1,i2];
            if (word1[i1] == word2[i2])
            {
                dp[i1,i2]= del(word1, word2, i1 - 1, i2 - 1,dp);
                return dp[i1,i2];
            }
            int ins = 1+del(word1, word2, i1, i2 - 1,dp);
            int dels = 1 + del(word1, word2, i1 - 1, i2,dp);
            int rep = 1 + del(word1,word2,i1-1,i2-1,dp);
            dp[i1,i2]= Math.Min(ins, Math.Min(rep, dels));
            return dp[i1,i2];   
        }
        private int rep(string word1, string word2, int i1, int i2)
        {
            return 0;
        }
        private int insert(string word1, string word2, int i1, int i2)
        {
            return 0;
        }
    }
}
