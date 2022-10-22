using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Heaps
{
    public partial class Heap
    {
        public void testcaseForCostToConnectNRopes()
        {
            //        Input: arr[] = { 4, 3, 2, 6 }, N = 4
            //Output: 29
            int[] arr = new int[] { 4, 3, 2, 6 };
            int N = 4;
            minCost(arr, N);    
        }
        private int minCost(int[]arr, int N)
        {
            Array.Sort(arr);
            List<int> ds = new List<int>();
            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
            int minCost = 0;
            for(int i=0;i<arr.Length;i++)
            {
                minCost = 0;
                minHeap.Enqueue(arr[i],arr[i]);
                if(minHeap.Count ==2)
                {
                    int k = 2;
                    while(k>0)
                    {
                        minCost = minCost + minHeap.Dequeue();
                        k--;
                    }
                    ds.Add(minCost);
                    minHeap.Enqueue(minCost,minCost);
                }
            }
            int totCost = 0;
            for(int i=0;i<ds.Count;i++) 
                totCost+=ds[i];
            return totCost; 
        }
    }
}
