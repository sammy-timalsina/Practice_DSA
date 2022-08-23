using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Recursions
{
    public partial class Recursion
    {
        public int[] ConstructRectangle(int area)
        {
            int w = (int)Math.Sqrt(area);
            while(area%w != 0)
            {
                w--;
            }
            int[] ans = new int[] { area / w, w };
            int l1 = 1;
            int w1 = 1;
    
         
            Dictionary<int[], int> kv = new Dictionary<int[], int>();
            ConstructRectangle(area, l1, w1, kv);
            int[] x = kv.OrderBy(x => x.Value).Select(x=>x.Key).First();
            return x;

        }
        void ConstructRectangle(int area, int l1, int w1, Dictionary<int[],int> kv)
        {
            
            int A1 = l1 * w1;
            int diff = l1 - w1;
            
            if(A1>area || w1>l1)
            {
                return;
            }
            else if(A1 == area)
            {
                   kv.Add(new[] { l1, w1 }, diff);
                return;
            }
            else
            { 
                ConstructRectangle(area, l1 + 1, w1, kv);
                ConstructRectangle(area, l1, w1 + 1, kv);
            }
        }
    }
}
