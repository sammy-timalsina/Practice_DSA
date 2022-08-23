using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public List<List<int>> getAllPerms(int[] arr)
        {
            List<List<int>> bl = new List<List<int>>();
            List<int> sl = new List<int>();
            sl = arr.ToList();
            getAllPerms(sl, 0, bl);
            return bl;
        }
         void getAllPerms(List<int> arr, int ind, List<List<int>> bl)
        {
            if(ind == arr.Count-1)
            {
                return;
            }
            int temp = 0;
 
            for (int i=0;i<arr.Count;i++)
            {
                //swap operation
                temp = arr[ind + 1];
                arr[ind + 1] = arr[ind];
                arr[ind] = temp;
                List<int> ll = new List<int>(arr);
                bl.Add(ll);
                //
                getAllPerms(arr, ind + 1, bl);

                //reverse the swap
                temp = arr[ind + 1];
                arr[ind + 1] = arr[ind];
                arr[ind] = temp;
            }
        }
    }
}
