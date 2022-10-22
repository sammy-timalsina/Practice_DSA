using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Heaps
{
    public partial class Heap
    {
        public void testCaseForKClosestPoints()
        {
            // Input: points = [[3, 3],[5,-1],[-2,4]], k = 2
            //Output:[[3,3],[-2,4]]
            //Explanation: The answer[[-2,4],[3,3]] would also be accepted.
            int[][] p = new int[][]
            {
                new int[]{3,3},
                new int[]{5,-1},
                new int[]{-2,4}
            };
            var ans = KClosest(p, 2);
        }

        class MaxHeapCmp : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x > y) return -1;
                else if (x < y) return 1;
                else return 0;
            }
        }
        public int[][] KClosest(int[][] points, int k)
        {
            MaxHeapCmp cmp = new MaxHeapCmp();
            PriorityQueue<int[], int> maxHeap = new PriorityQueue<int[], int>(cmp);
            for (int i = 0; i < points.Length; i++)
            {
                int distSquare = points[i][0] * points[i][0] + points[i][1] * points[i][1];
                maxHeap.Enqueue(points[i],(int) Math.Sqrt(distSquare));
                if (maxHeap.Count > k)
                    maxHeap.Dequeue();
            }
            int[][] closestPoints = new int[k][];
            for (int i = 0; i < k; i++)
            {
                closestPoints[i] = maxHeap.Dequeue();
            }
            return closestPoints;
        }
    }
}
