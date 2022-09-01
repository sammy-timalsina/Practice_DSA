using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.SlidingWindows
{
    public partial class SlidingWindow
    {
        public void testCaseForMinSwapRequiredToGroupAll1Together()
        {
            //        Input: arr[] = { 1, 0, 0, 0, 1,0,0,0,1 }
            //Output: 1
            //Explanation:
            //            Only 1 swap is required to group all 1's together. 
            //Swapping index 1 and 4 will give arr[] = { 1, 1, 1, 0, 0 }.
            //1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1
            int[] arr = new int[] { 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1 };
           // int[] arr = new int[] { 0,1,1};
            int minOps = minSwaps(arr, arr.Length);
        }
        int minSwaps(int[] arr, int n)
        {

            // Complete the function
            //1. Count total no. of ones
            int totOnes = 0;
            for(int i=0;i<n;i++)
            {
                if(arr[i] == 1)
                {
                    totOnes++;
                }
            }
            int k = 0;
            Dictionary<int, int> tmp = new Dictionary<int, int>();
            for(int i=0;i<n;i++)
            {
                if(i+totOnes-1>=n)
                {
                    break;
                }
                int count = 0;
                for(int j=i;j<i+totOnes;j++)
                {
                    if(arr[j]==0)
                    {
                        count++;
                    }
                    k = j;
                }         
                tmp.Add(k, count);
            }
            var minVal0 = tmp.OrderBy(x=>x.Value).First();
            return minVal0.Value;
        }
    }

}
