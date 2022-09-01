using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Recursions
{
    public partial class Recursion
    {
        public void arrangeCoinTestCase()
        {
            int n = 2147483647;
            int nx = int.MaxValue;
            int ct = ArrangeCoins(n);
        }
        private int ArrangeCoins(int n)
        {
            int sum = 0;
            int count = 0;
            ArrangeCoins(n, ref sum, ref count);    
            return count;
        }
        private void ArrangeCoins(int n,ref int sum,ref int count)
        {
            while(n-sum>=count)
            {
                count++;
                sum = sum + count;
            }
        }
    }
}
