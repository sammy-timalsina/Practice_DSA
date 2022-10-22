using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Heaps
{
    public partial class Heap
    {
        class Cmp : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x > y) return -1;
                else if (x < y) return 1;
                else return 0;
            }
        }
        public int NthUglyNumber(int n)
        {
            //let's create a priority queue
            Cmp cmp = new Cmp();
            PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>(cmp);
            int num = 1;
            maxHeap.Enqueue(num, num);
            while (maxHeap.Count < n)
            {
                num = num + 1;
                if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0)
                {
                    maxHeap.Enqueue(num, num);
                }
            }
            return maxHeap.Peek();
        }
    }
}
