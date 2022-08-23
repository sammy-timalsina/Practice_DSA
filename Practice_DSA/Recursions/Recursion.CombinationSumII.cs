using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Recursions
{
    public partial class Recursion
    {
        public IList<List<int>> getCombinationSumII(int[] arr, int target)
        {
            Dictionary< int, List<int>> ans = new Dictionary<  int, List<int>>();
     
           // IList<List<int>> ans = new List<List<int>>();
            List<int> ds = new List<int>();
            int count = 0;
            getCombinationSumII(0, arr, target, ds, ans, count);
            return null;
        }
        private void getCombinationSumII(int ind, int[] arr, int target, List<int> ds, Dictionary<int, List<int>> ans, int count)
        {
            if (ind == arr.Length)
            {
                return;
            }
            else if (target < 0)
            {
                return;
            }

            //take
            ds.Add(arr[ind]);
            if (target - arr[ind] == 0)
            {
               
                if(!ans.ContainsValue(new List<int>(ds)))
                {
                    count++;

                    ans.TryAdd( count, new List<int>(ds));
                }
                return;
               // ans.Add(new List<int>(ds));
            }
            if (arr[ind] <= target)
            {
                getCombinationSumII(ind + 1, arr, target - arr[ind], ds, ans,count);
            }
            //dont take
            ds.Remove(arr[ind]);
            getCombinationSumII(ind + 1, arr, target, ds, ans, count);
        }
    }
}
