using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Stacks
{
    public partial class cStack
    {
        public bool IsValid(string s)
        {

            Stack<int> st = new Stack<int>();
            Dictionary<char, int> kv = new Dictionary<char, int>
            { { '(', 1 }, { ')', 2 },
            { '{', 10 }, { '}', 11},
            { '[', 20 }, { ']', 21 }};
            for (int i = 0; i < s.Length; i++)
            {
                if (st.Count == 0)
                {
                    st.Push(kv[s[i]]);
                }
                else if (st.Peek() + 1 == kv[s[i]])
                {
                    st.Pop();
                }
                else
                {
                    st.Push(kv[s[i]]);
                }
            }
            if (st.Count == 0)
            {
                return true;
            }
            return false;
        }
        public int LongestValidParentheses(string s)
        {
            if(s.Length == 1)
            {
                return 0;
            }
            s = s + "!";
            Stack<int> st = new Stack<int>();
            Dictionary<char, int> kv = new Dictionary<char, int>
            { { '(', 1 }, { ')', 2 },{ '!',99 } };
            List<int> buckets = new List<int>();
            int counter = 0;
            int pushedCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (st.Count == 0)
                {
                    st.Push(kv[s[i]]);
                }
                else if (st.Peek() + 1 == kv[s[i]])
                {
                    pushedCount =0 ;
                    st.Pop();
                    counter++;
                }
                else
                {
                    pushedCount++;
                    if(pushedCount == 2)
                    {
                        if (counter != 0)
                        {
                            buckets.Add(counter);
                        }
                        counter = 0;
                    }
                    st.Push(kv[s[i]]);
                }
                if(kv[s[i]] == 99)
                {
                    buckets.Add(counter);

                }
            }
            if(buckets.Count >0)
            {
                return 2*buckets.Max();
            }
            return 0;
        }
    }
}
