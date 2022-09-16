using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Recursions
{
    public partial class Recursion
    {
        public void testCaseForPowerSum()
        {
            int num = 2;
            int ls = num << 1;
            int ls2 = ls << 1;
            int expected = 561;
            //bool result = actual == expected;
            //expected output 55
            //x = 1000 n = 10  output is 0
            //x =800 n=2 expected is 2
            //x = 800 n = 2 expected 561
        }
        public int powerSum(int X, int N)
        {
            double div =(float) 1 / N;
            int powOfX = (int) Math.Pow(X, div);
            int[] arr = new int[powOfX];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = (int)Math.Pow(i+1, N);
            }
            int ind = arr.Length-1;
            List<List<int>> ans = new List<List<int>>();
            List<int> ds = new List<int>();
            int tot = powerSum(arr,ind,X,ds,ans);
            return tot;
        }
        private int powerSum(int[]arr,int ind,int target, List<int>ds, List<List<int>> ans)
        {
            if(ind < 0)
            {
                if (target == 0)
                {
                    ans.Add(new List<int>(ds));
                    return 1;
                }    
                else 
                    return 0;
            }
            int pick = 0;

            if(arr[ind] <= target)
            {
                ds.Add(arr[ind]);
                pick = powerSum(arr,ind-1,target-arr[ind],ds,ans);
                ds.Remove(arr[ind]);
            }
            int dontPick = powerSum(arr, ind - 1, target,ds,ans);
            return pick + dontPick;
        }
    }
}
