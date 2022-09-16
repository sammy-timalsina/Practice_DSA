using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            Dictionary<int, int> kv = new Dictionary<int, int>();
            List<int> ds = new List<int>();
            for(int i=0;i<nums.Length;i++)
            {
                if(kv.ContainsKey(nums[i]))
                {
                    kv[nums[i]]++;
                    continue;
                }
                kv.Add(nums[i],1);
            }
            Array.Sort(nums);
            HelperPerm(nums, kv,ds, ans);
            return ans;
        }
        private void HelperPerm(int[] arr, Dictionary<int, int> kv,List<int>ds, IList<IList<int>> vector)
        {
            if (ds.Count == arr.Length)
            {
               // List<int> vec = kv.Values.ToList();
                vector.Add(new List<int>(ds));
                return;
 
            }
            int i = 0;
            while (kv[arr[i]] > 0)
            {
                
                ds.Add(arr[i]);
                kv[arr[i]]--;
                i++;
                HelperPerm(arr, kv, ds, vector);
                ds.Remove(arr[i]);
  
            }
            
        }
    }
}
