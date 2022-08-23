using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Recursions
{
    public partial class Recursion
    {
        public List<string> getAllSubsetsII(int[] arr)
        {
            HashSet<string> hs = new HashSet<string>();
            List<int> bucket = new List<int>();
            getAllSubsetsII(arr, 0, bucket,hs);
            return hs.ToList();
        }

        private void getAllSubsetsII(int[] arr, int ind, List<int> ds, HashSet<string> ans)
        {
            //This is a brute force solution
            if(ind == arr.Length)
            {
                List<int> ls = new List<int>(ds);
                string s = string.Empty;
                for(int i=0;i<ls.Count;i++)
                {
                    s += ls[i];
                }
                ans.Add(s);
                return;
            }
            //pick
            ds.Add(arr[ind]);
            getAllSubsetsII(arr, ind + 1, ds, ans);
            //don't pick 
            ds.Remove(arr[ind]);
            getAllSubsetsII(arr, ind + 1, ds, ans);
        }
        private void getAllSubsetsII(int[] arr, int ind, List<int> ds, List<List<int>> ans)
        {
            //This is a brute force solution
            if (ind == arr.Length)
            {
                return;
            }
            int prevIndex = -1;
            for(int i=0;i < arr.Length;i++)
            {
                if(ind==prevIndex)
                {
                    continue;
                }
                prevIndex = ind;
                ds.Add(arr[ind]);
                getAllSubsetsII(arr, ind + 1, ds, ans);
                ds.Remove(arr[ind]);
                getAllSubsetsII(arr, ind + 1, ds, ans);
            }
        }
    }
}
