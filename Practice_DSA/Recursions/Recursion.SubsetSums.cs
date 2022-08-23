using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Recursions
{
    public partial class Recursion
    {
        public List<int> getAllSubsetSums(int[]arr)
        {
            List<int> ds = new List<int>();
            List<int> ans = new List<int>();
            getAllSubsetSums(arr, 0, ds,ans);
            return ds;
        }
        void getAllSubsetSums(int[] arr, int index, List<int> ds, List<int> ans)
        {
            if(index == arr.Length)
            {
                int sum = 0;
                for(int i= 0;i< ds.Count;i++)
                {
                    sum += ds[i];
                }
                ans.Add(sum);
                return;
            }
            //pick
            ds.Add(arr[index]);
            getAllSubsetSums(arr, index + 1, ds,ans);
            //don't pick
            ds.Remove(arr[index]);
            getAllSubsetSums(arr, index + 1, ds,ans);
        }
    }
}
