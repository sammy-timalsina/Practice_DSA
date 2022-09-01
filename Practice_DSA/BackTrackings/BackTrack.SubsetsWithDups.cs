using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> ans = new List<IList<int>>();
            List<int> ls = new List<int>();
            SubsetsWithDup(nums, 0, ls, ans);
            return ans;

        }
        void SubsetsWithDup(int[] nums,int index, List<int>ds , IList<IList<int>> ans)
        {
            if(index == nums.Length)
            {
                
                for(int i=0;i<ans.Count;i++)
                {
                    if(ans[i].SequenceEqual(ds))
                    {
                        return;
                    }
                }
                ans.Add(new List<int>(ds));
                return;
            }
            //pick
                ds.Add(nums[index]);
                SubsetsWithDup(nums, index + 1, ds, ans);
                ds.Remove(nums[index]);
            //dont pick
            SubsetsWithDup(nums, index + 1, ds, ans);
        }
    }
}
