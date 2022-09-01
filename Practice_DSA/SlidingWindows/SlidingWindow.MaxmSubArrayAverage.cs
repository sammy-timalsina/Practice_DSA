using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.SlidingWindows
{
    public partial class SlidingWindow
    {
        public double FindMaxAverageBruteForce(int[] nums, int k)
        {
            //https://leetcode.com/submissions/detail/787736251/
            double maxSum = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if(i+k-1>=nums.Length)
                {
                    break;
                }
                double sum = 0.0;
                for (int j = i; j < i + k; j++)
                {
                    sum = sum + nums[j];
                }
                maxSum = Math.Max(maxSum, sum);
            }
            return maxSum / k;
        }
        public double FindMaxAverage(int[] nums, int k)
        {
            //https://leetcode.com/submissions/detail/787736251/
            double maxSum = int.MinValue;
            double initSum = 0.0;
            for(int i=0;i<k;i++)
            {
                initSum = initSum + nums[i];  
            }
            maxSum = Math.Max(maxSum, initSum);
            int x = k;
            for (int i =1; i < nums.Length-k+1; i++)
            {
                initSum = initSum - nums[i-1] + nums[x];
                maxSum = Math.Max(maxSum, initSum);
                x++;
            }
            return maxSum / k;
        }
    }
}
