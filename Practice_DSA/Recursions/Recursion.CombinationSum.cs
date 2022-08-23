using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Recursions
{
    public partial class Recursion
    {
      
        public IList<List<int>> getCombinationSum(int[] arr, int target)
        {
            IList<List<int>> ans = new List<List<int>>();
            List<int> ds = new List<int>();
            getCombinationSum(0, arr, target, ds, ans);
            return ans;
        }
        private void getCombinationSum(int ind, int[] arr,int target, List<int> ds, IList<List<int>> ans)
        {
            if(ind == arr.Length)
            {
                return;
            }
            else if(target<0)
            {
                return;
            }
            //take
            ds.Add(arr[ind]);
            if (target - arr[ind] == 0)
            {
                if(ans.Contains(new List<int>(ds)))
                {
                    int count = 1;
                }
                ans.Add(new List<int>(ds));
            }
            getCombinationSum(ind, arr, target - arr[ind], ds,ans);
            //dont take
            ds.Remove(arr[ind]);
            getCombinationSum(ind + 1, arr, target, ds, ans);
        }
    }
}
