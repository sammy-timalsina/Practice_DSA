using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Heaps
{
    public partial class Heap
    {
        public int getKthSmallestElement(int [] arr, int k)
        {
            PriorityQueue<int, int> maxHeap = new(new IntMaxComparer());
            for(int i=0;i<arr.Length;i++)
            {
                maxHeap.Enqueue(i, arr[i]);
                if (maxHeap.Count > k)
                {
                    maxHeap.Dequeue();
                }
            }
            return maxHeap.Peek();
        }
    }
}
