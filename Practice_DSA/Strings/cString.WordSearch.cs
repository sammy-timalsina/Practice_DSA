using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Strings
{
    public partial class cString
    {
        public void testCaseWordBreak()
        {
            // Input: s = "leetcode", wordDict = ["leet", "code"]
            //  Input: s = "catsandog", wordDict = ["cats", "dog", "sand", "and", "cat"]
            string s1 = "leetcode";
            IList<string> s2 = new List<string>() { "leet", "code" };
            //
           bool ans1= WordBreak(s1, s2);
            string s11 = "catsanddog";
            IList<string> s22 = new List<string>() { "cats", "dog","sand","and","cat" };
            bool ans2 =WordBreak(s11, s22);
        }
        public bool WordBreak(string s, IList<string> wordDict)
        {
            int len = s.Length;
            int wordDictLength = wordDict.Count;
            bool wordFound = false;
            for (int i = 0; i < wordDictLength; i++)
            {
                string currWord = wordDict[i];
                len = s.Length;
                for (int j = 0; j < len; j++)
                {
                    if (currWord[0] == s[j])
                    {
                        wordFound = true;
                        int k = currWord.Length;
                        int ptr = 0;
                        int strPtr = j;
                        while (ptr < k)
                        {
                            if (currWord[ptr] != s[strPtr])
                            {
                                ptr = 0;
                                strPtr = 0;
                                break;
                            }
                            ptr++;
                            strPtr++;
                        }
                        if (ptr != 0)
                        {
                            s= s.Remove(j, ptr);
                            break;
                        } 
                    }
                    else
                    {
                        wordFound = false ;
                    }
                }
                if (!wordFound) return false;
            }
            if (s.Length == 0) return true;
            else return false;
        }
    }
}
