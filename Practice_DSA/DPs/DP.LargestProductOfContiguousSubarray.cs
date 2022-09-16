using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public void testCaseForMaxPRoduct()
        {
            int[] n = new int[] { 1, 2, 3,4,5,6};
            int target = 8;
            CombinationSum44(n, target);
            int[] nums = new int[] { -1, 0, -2, 1, 1, 1, 1, 1, 1, 2, 3, 3, 3, 3, 4, 4, 5, 1};
            int ans1 = helper(nums);
            int ans = MaxProduct(nums);
        }
        public int MaxProduct(int[] nums)
        {
            //brute force solution
            int maxProd = int.MinValue;
            int len = nums.Length - 1;
            for (int i = 0; i < nums.Length; i++)
            {
                int prod = 1;
                int j = len;
                while (j >= i)
                {
                    prod = prod * nums[len - j+i];
                    maxProd = Math.Max(maxProd, prod);
                    j--;
                }
            }
            return maxProd;
        }
        private int helper(int[] nums)
        {      
            int prod = 1;
            int l = nums.Length - 1;

            //find number of zeros 
            int zeros = 0;
            for(int i=0;i< nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeros++;
                    nums[i] = 1;
                }

            }
            for(int i= 0;i<=l;i++)
                prod = prod * nums[i];
            int max = Math.Max(prod, nums[l]);
            for(int i=l;i>0;i--)
            {
                int x = nums[i];
                if (nums[i] == 0)
                    x = 1;
                
                prod = prod / x;
                max = Math.Max(prod,max);
            }
            if(zeros>0)
            {
                return max - zeros;
            }
            return max; 
        }
    }
}
