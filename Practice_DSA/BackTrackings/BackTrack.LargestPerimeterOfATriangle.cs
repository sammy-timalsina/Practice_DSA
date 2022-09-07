using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public void testCaseLargestPerimeter()
        {
            //[1,1,5,2,3]
            //int[] arr = new int[] { 3,6,2,3 };
            int[] arr = new int[] { 1,1,5,2,3 };
            int peri = LargestPerimeter(arr);
        }
        public int LargestPerimeter(int[] nums)
        {
            //first step sort the array
            Array.Sort(nums);
            int len = nums.Length - 1;
            //second step calculate semiperimeter
            double semiperimeter = 0;
            int m = 0;
            while (m < 3)
            {
                semiperimeter = semiperimeter + ((double)nums[len - m] / 2);
                m++;
            }
            double ans = 0.0;
            bool IsBad = true;
            m = 0;
            while (m < 3)
            {
                if (semiperimeter - nums[len - m] <= 0)
                {
                    IsBad = false;
                    break;
                }
                m++;
            }
            if (!IsBad && nums.Length == 3)
            {
                return 0;
            }
            else if (IsBad && nums.Length == 3)
            {
                ans = 2 * semiperimeter;
                return (int)ans;
            }
            else
            {
                for (int i = nums.Length - 1; i >= 2; i--)
                {
                    int k = i;
                    double lim = 0;
                    int n = 0;
                    while (n < 3)
                    {
                        lim = semiperimeter - nums[k - n];
                        if (lim <= 0)
                        {
                            break;
                        }
                        n++;
                    }
                    if (lim > 0)
                    {
                        ans = 2 * semiperimeter;
                        return (int)ans;
                    }
                    else
                    {
                        if (i - 3 < 0)
                        {
                            break;
                        }
                        semiperimeter = semiperimeter - ((double)nums[i] / 2) + (((double)nums[i - 3]) / 2);
                    }
                }
            }
            return 0;
        }
    }
}
