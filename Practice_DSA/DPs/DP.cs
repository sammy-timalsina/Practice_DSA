using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        int r1 = 101;
        int c1 = 101;
        private int[,] t;
        public DP()
        {
            t = new int[r1, c1];
            for(int i = 0;i<r1;i++)
            {
                for(int j=0;j<c1;j++)
                {
                    t[i, j] = 0;
                }
            }
        }
    }
}
