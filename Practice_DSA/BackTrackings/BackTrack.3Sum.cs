using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public IList<IList<int>> ThreeSumTest(int[] nums)
        {
            int count = 0;
            Array.Sort(nums);
            IList<IList<int>> vector = new List<IList<int>>();
            vector = ThreeSumTwoPtr(nums);  
            List<int> list = new List<int>();
            btr(nums, 0, count, list, vector);
            return vector;
        }
        private void btr(int[]nums, int index, int count, List<int>ds,IList<IList<int>> vector)
        {
            if(ds.Count == 3 && count ==0)
            {
                for(int i=0;i<vector.Count;i++)
                {
                    if (vector[i].SequenceEqual(ds))
                        return;
                }
                vector.Add(new List<int>(ds));
                return;
            }
            else if(ds.Count == 3 && count!=0)
            {
                return;
            }
            for(int i=index; i<nums.Length; i++)
            {
                count = count + nums[i];
                ds.Add(nums[i]);
                btr(nums, i+1, count, ds,vector);
                ds.Remove(nums[i]);
                count = count - nums[i];
            }
        }
        private IList<IList<int>> ThreeSumTwoPtr(int[] nums)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            for (int i=0;i<nums.Length; i++)
            {
                if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
                {
                    int ptrX = i + 1;
                    int ptrY = nums.Length - 1;
                    int sumBplusC = -(nums[i]);
                    while (ptrX < ptrY)
                    {
                        if (nums[ptrX] + nums[ptrY] == sumBplusC)
                        {
                            ans.Add(new List<int>() { nums[ptrX], nums[ptrY], -sumBplusC });
                            while (ptrX < ptrY && nums[ptrX] == nums[ptrX + 1]) ptrX++;
                            while (ptrX < ptrY && nums[ptrY] == nums[ptrY - 1]) ptrY--;
                            ptrX++;
                            ptrY--;

                        }
                        else if (nums[ptrX] + nums[ptrY] > sumBplusC)
                        {
                            ptrY--;
                        }
                        else
                        {
                            ptrX++;
                        }
                    }
                }
            }
            return ans;
        }
    }
}
