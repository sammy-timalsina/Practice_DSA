using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Maps
{
    public partial class cMap
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            for(int i=0; i<nums.Length;i++)
            {
                if(hs.Contains(nums[i]))
                {
                    return true;
                }
                hs.Add(nums[i]);
            }
            return false;
        }
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            //Array.Sort(nums);
            Dictionary<int, int> kv = new Dictionary<int, int>();
            bool result = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!kv.ContainsKey(nums[i]))
                {
                    kv.Add(nums[i], i);
                }
                else
                {
                    int x = kv[nums[i]];
                    int temp = Math.Abs(i - kv[nums[i]]);
                   // result = result && temp > k;
                    if (temp > k)
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                    kv[nums[i]] = i;
                }
            }
            return result;
     
        }
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            Dictionary<int, int> kv = new Dictionary<int, int>();
            bool result = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!kv.ContainsKey(nums[i]))
                {
                    kv.Add(nums[i], i);
                }
                else
                {
                    int x = kv[nums[i]];
                    int outVal = 0;
                    kv.TryGetValue(kv[nums[i]],out outVal);
                    int temp = Math.Abs(i - kv[nums[i]]);
                    int constr = Math.Abs(nums[i] - nums[outVal]);
                    // result = result && temp > k;
                    if(temp <= k && constr <=t)
                    {
                        result = true;
                    }
                    kv[nums[i]] = i;
                }
            }
            return result;
        }
    }
}
