using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Stacks
{
    public partial class cStack
    {
        public void testCaseForRemoveKDigits()
        {
  
            int x = 1500; int y = 3;
            string ab = Convert.ToString(x, toBase: 2);
            string ans = RemoveKdigits("1000000000200", 2);
        }
        public string RemoveKdigits(string num, int k)
        {
            //first find the length of number
            Stack<char> st = new Stack<char>();
            Stack<char> dummy = new Stack<char>();
            int len = num.Length;
            int ansLen = len - k;
            for (int i = len - 1; i >= 0; i--)
            {
                if (st.Count < ansLen)
                {
                    st.Push(num[i]);
                }
                else
                {
                    if (st.Peek() > num[i])
                    {
                        st.Pop();
                        st.Push(num[i]);
                    }
                    else if (st.Peek() == num[i])
                    {
                        int operationCount = 0;
                        while (st.Count > 0)
                        {
                            char topElement = st.Peek();
                            if (topElement > num[i])
                            {
                                st.Pop();
                                st.Push(num[i]);
                                break;
                            }
                            else if (topElement == num[i])
                            {
                                dummy.Push(st.Pop());
                            }
                            else if (operationCount == st.Count) break;
                            else
                            {
                                operationCount++;
                                break;
                            }
                        }
                        while (dummy.Count > 0)
                        {
                            st.Push(dummy.Pop());
                        }
                    }
                }
            }
            int j = 0;
            string ans = string.Empty;
            while (st.Count > 0)
            {
                ans = ans + st.Pop();
            }
            int ansNum = Convert.ToInt16(ans);
            return ansNum.ToString();
            return ans;
        }
    }
}
