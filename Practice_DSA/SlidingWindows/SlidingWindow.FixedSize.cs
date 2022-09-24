using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.SlidingWindows
{
    public partial class SlidingWindow
    {
        public void testCaseForFixedSizeProblems()
        {
            int[] ip = new int[] { 2, 5, 1, 8, 2, 9, 1 };
            int len = ip.Length;
            int k = 3;
            List<int> ans1 = firstNegativeInt(new int[] { 12, -1, -7, 8, -15, 30, 16, 28 },8,3);
            int[] ans = getMaximumSubArray(ip, len, k);
        }
        private int[] getMaximumSubArray(int[] arr, int len, int k)
        {
            int sum = 0;
            int max = int.MinValue;
            List<int> list = new List<int>();
            int i = 0;
            int j = 0;
            while(i < len-k)
            {
                if(j-i+1 == k)
                {
                    sum = sum + arr[j] - arr[i];
                    max = Math.Max(max, sum);
                    i++;
                    j++;
                }
                else
                {
                    sum = sum + arr[j];
                    max = Math.Max(max, sum);
                    j++;
                }
            }
            return list.ToArray();  
        }
        private List<int> firstNegativeInt(int[]arr, int len, int k)
        {

            string s = "abc";
            string s1 = "cba";
            char[] arrx = s1.ToCharArray();

            Array.Sort(arrx);
            string s11 = string.Empty;
            for (int i = 0; i < arrx.Length; i++) s11 = s11 + arrx[i];
            bool stat = false;
            List<int> list = new List<int>();
            Queue<int> ds = new Queue<int>();
            //first window
            for(int i=0;i<k;i++)
            {
                if(arr[i] < 0 && list.Count == 0)
                {
                    ds.Enqueue(arr[i]);
                    list.Add(arr[i]);
                }
                else if(arr[i]<0) ds.Enqueue(arr[i]);
            }
            //
            for(int i=1;i<=len-k;i++)
            {
                int j = k + i - 1;
                if(ds.Count==0)
                {
                    if (arr[i] < 0)
                    {
                        list.Add(arr[i]);
                    }
                    else
                    {
                        list.Add(0);
                    }
                }
                else if (ds.Count > 0)
                {
                    list.Add(ds.Dequeue());
                    if(arr[j]<0)
                    {
                        ds.Enqueue(arr[j]);
                    }
                }
            }
            return list;
        }
    }
}
