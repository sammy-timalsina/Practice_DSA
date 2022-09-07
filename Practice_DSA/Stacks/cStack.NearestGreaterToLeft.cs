using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Stacks
{
    public partial class cStack
    {
        public List<int> getNearestGreaterToLeft(int[] arr)
        {
            Stack<int> s = new Stack<int>();
            List<int> vector = new List<int>(); 
            for(int i=0;i<arr.Length;i++)
            {
                if(s.Count == 0)
                {
                    vector.Add(-1);
                    s.Push(arr[i]);
                }
                else if(s.Count >0 && s.Peek() > arr[i])
                {
                    vector.Add(s.Peek());
                    s.Push(arr[i]);
                }
                else if(s.Count >0 && s.Peek() <= arr[i])
                {
                    while(s.Count >0)
                    {
                        if (s.Peek() > arr[i])
                        {                     
                            vector.Add(s.Peek());
                            s.Push(arr[i]);
                            break;
                        }
                        s.Pop();
                    }
                    if(s.Count == 0)
                    {
                        s.Push(arr[i]);
                        vector.Add(-1);
                    }
                }
            }
            return vector;
        }
    }
}
