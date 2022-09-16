using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public int CombinationSum44(int[] nums, int target)
        {
            int counter = 0;
            Dictionary<int,int> kv = new Dictionary<int,int>(); 
            helper(nums, 0,target,0,ref counter,kv);
            int sum = 0;    
            for(int i=2;i<8;i++)
            {
                sum += kv[i];
            }
            return counter;
            
        }
        public void helper(int[]nums,int index,int target,int state, ref int counter, Dictionary<int,int> ds)
        {
            if (state > target)
                return;
            else if(state == target)
            {
                counter++;
                if (!ds.ContainsKey(state - nums[index]))
                {
                    ds.Add(state - nums[index], counter);
                }
                return;
            } 
            if(ds.ContainsKey(state-nums[index]))
            {
                counter++;
                return;
            }
            for(int i=0;i<nums.Length;i++)
            {
                state = state +nums[i];
                helper(nums,i, target, state,ref counter,ds);
                state = state -nums[i];
            }
        }
    }
}
