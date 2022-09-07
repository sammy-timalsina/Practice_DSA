using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Stacks
{
    public partial class cStack
    {
        private List<int> getNextGreaterToRight(int[] arr)
        {

            int len = arr.Length-1;
            Stack<int> stack = new Stack<int>();
            List<int> list = new List<int>();
            for(int i=len; i>=0; i--)
            {
                if(stack.Count > 0 && stack.Peek() > arr[i])
                {
                    list.Add(stack.Peek());
                    stack.Push(arr[i]);
                }
                else if(stack.Count > 0 && stack.Peek() <= arr[i])
                {
                    while(stack.Count>0)
                    {
                        if(stack.Peek()> arr[i])
                        {
                            list.Add(stack.Peek());
                            stack.Push(arr[i]);
                            break;
                        }
                        stack.Pop();
                    }
                    if (stack.Count == 0)
                    {
                        list.Add(-1);
                        stack.Push(arr[i]);
                    }
                }
                else
                {
                    list.Add(-1);
                    stack.Push(arr[i]);
                }
            }
            return list;    
        }
    }
}
