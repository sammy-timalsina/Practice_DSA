using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BinarySearches
{
    public partial class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int val = Search(nums, target, 0, nums.Length - 1);
            return val;
        }
        private int Search(int[] nums, int target, int firstIndex, int lastIndex)
        {
            int ind = (firstIndex + lastIndex) / 2;
            if (nums[firstIndex] == target)
            {
                return firstIndex;
            }
            else if (nums[lastIndex] == target)
            {
                return lastIndex;
            }
            else if (nums[ind] == target)
            {
                return ind;
            }
            else if (Math.Abs(firstIndex - lastIndex) <= 1)
            {
                return -1;
            }
            else if (target > nums[ind])
            {
                firstIndex = ind;
            }
            else if (target < nums[ind])
            {
                lastIndex = ind;
            }           
            return Search(nums, target, firstIndex, lastIndex);
        }
        private int SearchIterative(int []nums, int target)
        {
            int firstIndex = 0;
            int lastIndex = nums.Length - 1;
            int ind = (firstIndex + lastIndex) / 2;

            while (nums[ind] != target)
            {
                if(nums[firstIndex] == target)
                {
                    return firstIndex;
                }
                else if(nums[lastIndex] == target)
                {
                    return lastIndex;
                }
                else if(target == nums[ind])
                {
                    return ind;
                }
                else if(target > nums[ind])
                {
                    firstIndex = ind;
                }
                else if(target < nums[ind])
                {
                    lastIndex = ind;
                }
                else if (Math.Abs(firstIndex - lastIndex) <= 1)
                {
                    return -1;
                }
                ind = (firstIndex + lastIndex) / 2;
            }
            return -1;
        }
    }
}
