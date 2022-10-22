using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Heaps
{
    public partial class Heap
    {
        public void testCaseForKLargest()
        {
            testDel();
            testcaseForCostToConnectNRopes();
            testCaseForKClosestPoints();
            int[] arr = new int[] { 7, 10, 4, 3, 20, 15 };
            int[] arr1 = new int[] { 5,6,7,8,9};
            int[] arr2 = new int[] { 1, 1, 1, 2, 2, 3 };
            int k = 3;
            //frequencySort(arr2);
            getKfrequentElement(arr2, 2);
            getKthClosestNumbers(arr1, 3, 7);
            int ans = getKthLargestElement(arr, k);
        }
        void testDel()
        {
            //generate lexico
           List<int> ds = new List<int>();
            bt(15, 1, ds);
        }
        private void bt(int n, int sn, List<int> ds)
        {
            if (sn > n)
                return;
            ds.Add(sn);
            bt(n, sn * 10, ds);
            bt(n, sn + 1, ds);
        }
        private int getKthLargestElement(int[]arr, int k)
        {
            PriorityQueue<int,int> minHeap = new PriorityQueue<int, int>();
            for(int i = 0; i < arr.Length; i++)
            {
                minHeap.Enqueue(arr[i], arr[i]);
                if(minHeap.Count > k)
                    minHeap.Dequeue();
            }
            return minHeap.Peek();
        }
        private void getKthClosestNumbers(int[]arr, int k, int num)
        {
            ComparerMaxHeap cmp = new ComparerMaxHeap();
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>(cmp);
            for(int i=0;i<arr.Length;i++)
            {
                pq.Enqueue(arr[i],Math.Abs(num-arr[i]));
                if(pq.Count > k)
                    pq.Dequeue();
            }
           int val = pq.Peek();
        }
        private List<int> getKfrequentElement(int[] arr, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i=0;i<arr.Length;i++ )
            {
                if(map.ContainsKey(arr[i]))map[arr[i]]++;
                else map.Add(arr[i], 1);
            }
            List<int> ds = new List<int>();
            ComparerMaxHeap cmp = new ComparerMaxHeap();
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>(cmp);
            List<int> ls =map.Keys.ToList();
            for(int i=0;i<ls.Count;i++)
            {
                pq.Enqueue(ls[i],map[ls[i]]);
                if (pq.Count > k)
                    pq.Dequeue();
            }
            for(int i=0;i<k;i++)
                ds.Add(pq.Dequeue());
            return ds;
        }
        private List<int> frequencySort(int []arr)
        {
            Dictionary<int,int> map = new Dictionary<int,int>();
            for(int i=0;i<arr.Length;i++)
            {
                if(!map.ContainsKey(arr[i]))
                {
                    map.Add(arr[i], 1);
                    continue;
                }
                map[arr[i]]++;  
            }
            ComparerMaxHeap cmp = new ComparerMaxHeap();
            PriorityQueue<Pair,int> pq = new PriorityQueue<Pair,int>(cmp);  
            List<int> keys =map.Keys.ToList();  
            for(int i=0;i<map.Count;i++)
                pq.Enqueue(new Pair(keys[i],map[keys[i]]), map[keys[i]]);
            List<int> ds = new List<int>();
            for(int i=0;i<map.Count;i++)
            {
                int k = 0;
                Pair pair= pq.Dequeue();
                while(k<pair.getFrequency())
                {
                    ds.Add(pair.getKey());
                    k++;
                }
            }
            return ds;
        }

    }
    public class ComparerMaxHeap2 : IComparer<Pair>
    {
        public int Compare(Pair x, Pair y)
        {
            if (x.getFrequency() > y.getFrequency()) return -1;
            else if (x.getFrequency() < y.getFrequency()) return 1;
            else return 0;
        }
    }
    public class ComparerMaxHeap : IComparer<int>
    {
        public int Compare(int x, int y)
        {
          if(x>y)return -1;
          else if(x<y)return 1;
          else return 0;
        }
    }
    public class Pair
    {
        int frequency;
        int key;
        public Pair(int a, int b)
        {
            key = a; frequency = b;
        }
        public int getFrequency()
        {
            return frequency;
        }
        public void setFrequency(int frequency)
        { this.frequency = frequency; }
        public int getKey()
        { return this.key; }
        public void setKey(int key)
        { this.key = key; }
    }
}

