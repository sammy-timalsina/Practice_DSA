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
            HashSet<string> hs = new HashSet<string>();
            getCombinationSum(0, arr, target, ds, ans);
            List<string> ls = hs.ToList();
            int len = hs.Count;
            for (int i = 0; i < len; i++)
            {
                List<int> bucket = new List<int>();
                string s = ls[i];
                for (int j = 0; j < ls[i].Length; j++)
                {
                    bucket.Add(Convert.ToInt16(s[j].ToString()));
                }
                ans.Add(bucket);
            }
            return ans;
        }
        private void getCombinationSumx(int ind, int[] arr,int target, List<int> ds, HashSet<string> ans)
        {
            //brute force approach to solve the problem.
            if(ind == arr.Length)
            {
                return;
            }
            else if(target<0)
            {
                return;
            }
            else if(target == 0)
            {
                string s = string.Empty;
                for(int i=0;i<ds.Count;i++)
                {
                    s += ds[i];
                }
                ans.Add(s);
                return;
            }
            //take
            ds.Add(arr[ind]);
            getCombinationSumx(ind, arr, target - arr[ind], ds,ans);
            //dont take
            ds.Remove(arr[ind]);
            getCombinationSumx(ind + 1, arr, target, ds, ans);
        }
        private void getCombinationSum(int ind, int[] arr, int target, List<int> ds, IList<List<int>> ans)
        {
            //brute force approach to solve the problem.
            if (ind == arr.Length)
            {
                if (target == 0)
                {
                    ans.Add(new List<int>(ds));
                }
                return;
            }

            //take
            if (arr[ind] <= target )
            {
                ds.Add(arr[ind]);
                getCombinationSum(ind, arr, target - arr[ind], ds, ans);
                //dont take
                ds.Remove(arr[ind]);
            }
            getCombinationSum(ind + 1, arr, target, ds, ans);
        }
    }
}
