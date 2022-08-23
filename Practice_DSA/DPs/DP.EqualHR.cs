using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {

        public  int substrings(string n, int len)
        {
            if(len == 0)
            {
                return 0;
            }
            int tot = substrings(n, len-1);
            int temp = 0;
           // int temp =Convert.ToInt32( n[len-1].ToString());
            for(int i=0;i<len-1;i++)
            {
                string ar = n.Substring(i, len - 1);
                temp = temp + Convert.ToInt32(ar);
            }
            int temp1 = Convert.ToInt32(n);
            return tot + temp+temp1;
        }
        public int equal(List<int> arr)
        {
            int count = 0;
            while (arr.Min() != arr.Max())
            {
                int min = arr.Min();
                int max = arr.Max();
                arr.Remove(max);
                int diff = max - min;
                arr.Add(min);
                int op = 0;
                if(diff%5==0)
                {
                    op = diff / 5;
                }
                else if(diff%2 ==0)
                {
                    op = diff / 2;
                }
                else
                {
                    op = 1;
                }
                count = count + op;
              
            }
            return count;
        }
    }
}
