using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Maps
{
    public partial class cMap
    {
        public int ArithmeticTriplets(int[] nums, int diff)
        {
            List<int> vs = new List<int>();
            for(int i=0;i<nums.Length;i++)
            {
                for(int j=0; j<=i;j++)
                {
                    if(nums[i]-nums[j]==diff)
                    {
                        if (!vs.Contains(i))
                        {
                            vs.Add(i);
                        }
                        if (!vs.Contains(j))
                        {
                            vs.Add(j);
                        }

                    }
                }
            }

            return 0;
        }
    }
}
