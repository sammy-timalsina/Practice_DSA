using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.StringAndArrays
{
    public partial class StringNArray
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> kv = new Dictionary<char, char>();
            Dictionary<char, char> kv2 = new Dictionary<char, char>();
            bool ans1 = false;
            bool ans2 = false;
            for (int i = 0; i < t.Length; i++)
            {
                if (!kv.ContainsKey(t[i]))
                {
                    kv.Add(t[i], s[i]);
                }
                if (!kv2.ContainsKey(s[i]))
                {
                    kv2.Add(s[i], t[i]);
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (kv[t[i]] != s[i])
                {
                    ans1 = false;
                    break;
                }
                else
                {
                    ans1 = true;
                }
                if (kv2[s[i]] != t[i])
                {
                    ans2 = false;
                    break;
                }
                else
                {
                    ans2 = true;
                }
            }
            return ans1 && ans2;
        }
    }
}
