using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            //submitted
            //https://leetcode.com/problems/subsets/submissions/
            IList<IList<int>>  ans = new List<IList<int>>();    
            IList<int> ds = new List<int>();
            Subsets(nums,0, ds, ans);
            return ans;
        }

        private void Subsets(int[] nums,int index, IList<int> ds, IList<IList<int>> ans)
        {
            if (index >= nums.Length)
            {
                ans.Add(new List<int>(ds));
                return;
            }
            //pick part
            ds.Add(nums[index]);
            Subsets(nums, index + 1, ds, ans);
            ds.Remove(nums[index]);
            //dont pick part
            Subsets(nums, index + 1, ds, ans);
        }
    }
}
