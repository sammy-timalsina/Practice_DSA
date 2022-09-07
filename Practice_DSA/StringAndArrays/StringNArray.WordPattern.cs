using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.StringAndArrays
{
    public partial class StringNArray
    {
        public void testCaseForWordPattern()
        {
            string pattern = "abba";
            string word = "dog dog dog dog";
            WordPattern(pattern, word);
        }
        public bool WordPattern(string pattern, string s)
        {
            string[] words = s.Split(' ');
            int j = words.Length - 1;
            int len = pattern.Length - 1;
            if(j!=len)
            {
                return false;
            }
            bool ans1 = true;
            bool ans2 = true;
            Dictionary<char, string> dic = new Dictionary<char, string>();
            Dictionary<string, char> dic2 = new Dictionary<string, char>();
            for(int i=0;i<words.Length;i++)
            {
                if(!dic.ContainsKey(pattern[i]))
                {
                    dic.Add(pattern[i], words[i]);  
                }
                if(!dic2.ContainsKey(words[i]))
                {
                    dic2.Add(words[i], pattern[i]); 
                }
            }

            for(int i=0;i<words.Length;i++)
            {
                if(dic[pattern[i]]!=words[i])
                {
                    ans1 = false;
                }
                if(dic2[words[i]]!=pattern[i])
                {
                    ans2 = false;
                }
            }
            return ans1 && ans2;
        }
    }
}
