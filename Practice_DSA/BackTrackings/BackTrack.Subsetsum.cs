using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public List<int> getAllSums(List<int> arr)
        {
            List<int> ds = new List<int>();
            getAllSums(arr, 0, 0, ds);
            return ds;
        }
        private void getAllSums(List<int> arr, int index, int sum, List<int> ds)
        {
            if(index >= arr.Count)
            {
                ds.Add(sum);
                return;
            }
            //pick
            int pickSum = sum + arr[index];
            getAllSums(arr, index + 1, pickSum, ds);
            //not pick
            getAllSums(arr, index + 1,sum, ds);
        }
    }
}
