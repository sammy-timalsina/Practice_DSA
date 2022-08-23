using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Stacks
{
    public partial class cStack
    {
        public int LengthOfLongestSubstring(string s)
        {
            int count = 0;
            List<int> maxLen = new List<int>();
            if (s.Length == 0) return 0;
            else if (s.Length == 1) return 1;
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    count = 0;
                    List<char> bucket = new List<char>();
                    for (int j = i; j < s.Length; j++)
                    {
                        if (!bucket.Contains(s[j]))
                        {
                            count++;
                            bucket.Add(s[j]);
                        }
                        else
                        { break; }
                    }
                    maxLen.Add(count);
                }
                return maxLen.Max();
            }
        }
    }
}
