using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Maps
{
    public partial class cMap
    {
        public int SingleNumber(int[] nums)
        {
            //using xor gate
            int xor = 0;
            for(int i=0;i<nums.Length;i++)
            {
                xor = xor ^ nums[i];
            }
            return xor;
            //Dictionary<int, int> kv =
            //    new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!kv.ContainsKey(nums[i]))
            //    {
            //        kv.Add(nums[i], 1);
            //        continue;
            //    }
            //    int val = 0;
            //    kv.TryGetValue(nums[i], out val);
            //    kv[nums[i]] = val + 1;
            //}
            //int minVal = kv.Values.Min();
            //KeyValuePair<int, int> keyForMinVal = kv.Where(X=>X.Value==minVal).FirstOrDefault();
            //return keyForMinVal.Key;
             
        }
    }
}
