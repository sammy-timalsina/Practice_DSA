using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            List<int> ls = new List<int>();
            Stack<int> qu = new Stack<int>();
            int poppedState = -1;
            Permute2(nums, qu,ans, poppedState);
            HashSet<IList<int>> hs = new HashSet<IList<int>>();
            for(int i=0;i <ans.Count;i++)
            {
                hs.Add(ans[i]);
            }
            return ans;
        }
        void Permute(int[] nums, List<int> ls, IList<IList<int>> ans)
        {
            if(ls.Count == nums.Length)
            {
                ans.Add(new List<int>(ls));
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (!ls.Contains(nums[i]))
                {
                    ls.Add(nums[i]);
                    Permute(nums, ls, ans);
                    ls.Remove(nums[i]);
                }
            }
        }
        void Permute2(int[] nums, Stack<int> ls, IList<IList<int>> ans, int prev)
        {
            if (ls.Count == nums.Length)
            {
                ans.Add(new List<int>(ls));
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (ls.Count == 0 && prev != nums[i])
                {
                    ls.Push(nums[i]);
                    prev = nums[i];
                    Permute2(nums, ls, ans,prev);
                    ls.Pop();
                }           
                else if(ls.Count > 0)
                {
                    int temp = ls.Peek();
                    if(ls.Peek() != nums[i] && prev != nums[i])
                    {
                        ls.Push(nums[i]);
                        prev = nums[i];
                        Permute2(nums, ls, ans,prev);
                        ls.Pop();
                    }
                }
            }
        }
    }
}
