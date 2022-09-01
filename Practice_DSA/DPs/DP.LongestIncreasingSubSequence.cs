using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public void LengthofLongestIncreSubSeq()
        {
            //dp.minTotalInAtriangle();
            //[4,10,4,3,8,9]
            //0,1,0,3,2,3
            //10, 9, 2, 5, 3, 7, 101, 18
            //7,7,7,7,7,7,7
            //[7,7,7,7,7,1,2,3,4,5,100,333,44,7,7] expected 7
            var ans = LengthOfLIS(new int[] { 4, 10, 4, 3, 8, 9 });
        }
        int LengthOfLIS(int[] nums)
        {
            int[,] dp = new int[nums.Length + 1, nums.Length + 1];
            for(int i=0;i<=nums.Length;i++)
            {
                for(int j=0;j<=nums.Length;j++)
                {
                    dp[i, j] = -1;
                }
            }
            HashSet<int> hs = new HashSet<int>();
            int[] nums2 = new int[nums.Length];
            for(int i=0;i<nums2.Length;i++)
            {
               hs.Add(nums[i]);
            }
            nums2 = hs.ToArray();
            Array.Sort(nums2);
            int ans = LengthOfLIS(nums, nums2, nums.Length - 1, nums2.Length - 1, dp);
            return ans;
        }
        int LengthOfLIS(int[] nums1,int[] nums2, int index1, int index2, int[,] dp)
        {
            if(index1 <0 || index2<0)
            {
                return 0;
            }
            if(dp[index1,index2]!=-1)
            {
                return dp[index1, index2];
            }
            int take = 0;
            if(nums1[index1]==nums2[index2])
            {
                take = 1 + LengthOfLIS(nums1, nums2, index1 - 1, index2 - 1, dp);
            }
            int notTake = Math.Max(LengthOfLIS(nums1, nums2, index1, index2 - 1, dp),
                LengthOfLIS(nums1, nums2, index1 - 1, index2, dp));
            dp[index1,index2]= Math.Max(take, notTake);
            return dp[index1, index2];
        }
        public List<List<int>> getLongestIncreasingSubsequence(int[] arr)
        {
            //remove duplicates from the array
            HashSet<int> ip = new HashSet<int>();
            for(int i=0;i<arr.Length;i++)
            {
                ip.Add(arr[i]);
            }
            int[] ip_arr = ip.ToArray();
            List<int> st = new List<int>();
            List<List<int>> ans = new List<List<int>>();
            int current = Int16.MinValue;
            int recCounter = 0;
            getLongestIncreasingSubsequence(arr, 0, st, ans,ref current,ref recCounter);
            int count = -1;
            for(int i=0;i<ans.Count;i++)
            {
                count = Math.Max(ans[i].Count, count);
            }
            return ans;
        }
        void getLongestIncreasingSubsequence(int[] arr, int ind, List<int> ds, List<List<int>> ans, ref int prev,ref int ct)
        {
            ct++;
            for (int i = ind; i < arr.Length; i++)
            {
                if (prev < arr[i])
                {
                    prev = arr[i];
                    ds.Add(arr[i]);
                    getLongestIncreasingSubsequence(arr, i + 1, ds, ans,ref prev,ref ct);
                    ds.Remove(arr[i]);
                }
            }
            ans.Add(new List<int>(ds));
            prev = -1;
        }
    }
}
