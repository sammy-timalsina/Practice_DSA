using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Practice_DSA.Stacks
{
    public partial class cStack
    {
        private void getNearestSmallerToLeft(int[] arr)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            List<int> ans1 = getNearestSmallerToLeftUsingStack(arr);
            sw1.Stop();
            var timeTaken2 = sw1.ElapsedMilliseconds;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<int> ans2 = getNearestSmallerBruteForce(arr);
            sw.Stop();
            var timeTaken1 = sw.ElapsedMilliseconds;
            bool stat = ans1.SequenceEqual(ans2);
        
        
        
        
        }
        private List<int> getNearestSmallerToLeftUsingStack(int[] arr)
        {
            //let us stack 
            Stack<int> s = new Stack<int>();
            List<int> vector = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (s.Count == 0)
                {
                    s.Push(arr[i]);
                    vector.Add(-1);
                }
                else if (s.Count > 0 && s.Peek() < arr[i])
                {
                    vector.Add(s.Peek());
                    s.Push(arr[i]);
                }
                else if (s.Count > 0 && s.Peek() >= arr[i])
                {
                    while (s.Count > 0)
                    {
                        if (s.Peek() < arr[i])
                        {
                            vector.Add(s.Peek());
                            s.Push(arr[i]);
                            break;
                        }
                        s.Pop();
                    }
                    if (s.Count == 0)
                    {
                        s.Push(arr[i]);
                        vector.Add(-1);
                    }
                }
            }
            return vector;
        }
        private List<int> getNearestSmallerBruteForce(int[] arr)
        {
            //let us see the problem using brute force method 
            List<int> vector = new List<int>();
            bool IsSmall = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] < arr[i])
                    {
                        vector.Add(arr[j]);
                        IsSmall = true;
                        break;
                    }
                }
                if (!IsSmall)
                {
                    vector.Add(-1);
                }
                IsSmall = false;
            }
            return vector;
        }
    }
}
