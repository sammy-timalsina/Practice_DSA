using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Maps
{
    public partial class cMap
    {
        public int RemoveDuplicates(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            int count = 0;
            int[] expectedNums = nums;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hs.Contains(nums[i]))
                {
                    hs.Add(nums[i]);
                    count++;
                }
            }
            List<int> ls = hs.ToList();
            for (int i = 0; i < ls.Count; i++)
            {
                expectedNums[i] = ls[i];
            }
            return count;
        }
        public int RemoveElement(int[] nums, int val)
        {
            int len = nums.Length;
            int count = 0;
            List<int> ls = new List<int>();
            for (int i = 0; i < len; i++)
            {
                if(nums[i]!=val)
                {
                    ls.Add(nums[i]);
                    continue;
                }
                count++;
            }
            Array.Copy(ls.ToArray(), nums, ls.Count);
            return count;
        }
    }
}
