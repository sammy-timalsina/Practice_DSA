using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Sortings
{
    public partial class cSorting
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            //create an array to use it for sorting
            int[] anst = new int[nums.Length];
            for(int i=0;i<anst.Length;i++)
            {
                anst[i] = nums[i];
            }
            Array.Sort(anst);
            //create a dictionary/ map
            Dictionary<int, int> kv = new Dictionary<int, int>();
            int count = 0;
            //store the element in dictionary from the sorted array
            //key is going to be anst array element and value
            //is counter
            for(int i=0;i<anst.Length;i++)
            {
                if(!kv.ContainsKey(anst[i]))
                {
                    kv.Add(anst[i], count);
                }
                count++;
            }
            //create ans array 
            //map nums array element using map and store the values in new ans array
            int[] ans = new int[nums.Length];
            for(int i=0;i<nums.Length;i++)
            {
                ans[i] = kv[nums[i]];
            }
            return ans;
        }
        private int[] bruteforcemethod(int[] nums)
        {
                    //This is a brute force approach 
        //This requires O(N^2);
            int[] arr = new int[nums.Length];
            for(int i=0;i<nums.Length;i++)
            {
                int count = 0;
                for(int j=0;j<nums.Length;j++)
                {
                    if(i!=j && nums[i]>nums[j])
                    {
                        count++;
                    }
                    arr[i] = count;
                }

            }
            return arr;
        }
    }
}
