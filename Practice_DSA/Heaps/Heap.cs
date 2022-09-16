using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Heaps
{
    public partial class Heap
    {
        //https://medium.com/@dorlugasigal/c-10-priorityqueue-is-here-5067e2628470
        public void testCaseForHeapProblems()
        {
            //    Input: arr[] = { 7, 10, 4, 3, 20, 15 }, K = 3
            //Output: 7

            //Input: arr[] = { 7, 10, 4, 3, 20, 15 }, K = 4
            //Output: 10
            int[] arr = new int[] { 7, 10, 4, 3, 20, 15 };
            int k = 3;
            int ans=getKthSmallestElement(arr,k);
        }
        public class IntMaxComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return y.CompareTo(x);
            }
        }
    }
}
