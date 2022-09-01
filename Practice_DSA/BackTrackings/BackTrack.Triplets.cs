using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            List<int> ds = new List<int>();
            HashSet<string> hs = new HashSet<string>();
            ThreeSum(nums, 0, ds, ans);
            return ans;
        }
        void ThreeSum(int[]nums, int index, List<int> ds, IList<IList<int>> ans)
        {
           
        }
    }
}
