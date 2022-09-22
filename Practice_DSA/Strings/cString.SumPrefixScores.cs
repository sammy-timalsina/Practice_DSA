using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Strings
{
    public partial class cString
    {
        public void testCaseForSumPrefixScore()
        {//https://leetcode.com/problems/maximum-value-of-k-coins-from-piles/
            //https://leetcode.com/problems/design-an-atm-machine/
            //https://leetcode.com/contest/weekly-contest-311/problems/sum-of-prefix-scores-of-strings/


            //            Example 1:

            //Input: words = ["abc", "ab", "bc", "b"]
            //Output:[5,4,3,2]
            //Explanation: The answer for each string is the following:
            //-"abc" has 3 prefixes: "a", "ab", and "abc".
            //- There are 2 strings with the prefix "a", 2 strings with the prefix "ab", and 1 string with the prefix "abc".
            //The total is answer[0] = 2 + 2 + 1 = 5.
            //- "ab" has 2 prefixes: "a" and "ab".
            //- There are 2 strings with the prefix "a", and 2 strings with the prefix "ab".
            //The total is answer[1] = 2 + 2 = 4.
            //- "bc" has 2 prefixes: "b" and "bc".
            //- There are 2 strings with the prefix "b", and 1 string with the prefix "bc".
            //The total is answer[2] = 2 + 1 = 3.
            //- "b" has 1 prefix: "b".
            //- There are 2 strings with the prefix "b".
            //The total is answer[3] = 2.

            //Example 2:

            //Input: words = ["abcd"]
            //Output: [4]
            //Explanation:
            //"abcd" has 4 prefixes: "a", "ab", "abc", and "abcd".
            //Each prefix has a score of one, so the total is answer[0] = 1 + 1 + 1 + 1 = 4.

            string[] ss = new string[] { "abc", "ab", "bc", "b" };
            SumPrefixScores(ss);
            string[] ss1 = new string[] { "abcd" };
            SumPrefixScores(ss1);
        }
        public int[] SumPrefixScores(string[] words)
        {

            Dictionary<string, int> map = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                string s = string.Empty;
                string curr = words[i];
                for (int j = 0; j < curr.Length; j++)
                {
                    s = s + curr[j];
                    if (!map.ContainsKey(s))
                    {
                        map.Add(s, 1);
                    }
                    else
                        map[s]++;
                }
            }
            List<string> ls = map.Select(x => x.Key).ToList();
            for (int i = 0; i < map.Count; i++)
            {
                if (map[ls[i]] > 1)
                    continue;
                string s = ls[i];
                int count = 0;
                int k = 0;
                string cs = string.Empty;
                while (k < s.Length)
                {
                    cs = cs + s[k];
                    count = count + map[cs];
                    k++;
                }
                map[s] = count;
            }
            int[] newarr = new int[words.Length];  
            for(int i=0;i<words.Length;i++)
            {
                newarr[i] = map[words[i]];
            }
            return newarr;
        }
    }
}
