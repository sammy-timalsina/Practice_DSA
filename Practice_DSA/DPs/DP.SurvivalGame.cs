using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public void testGame()
        {
            area x = new area(3, 2);
            area y = new area(-5, -10);
            area z = new area(-20, 5);
            int PA = 20;
            int PB = 8;
            int ms1 = maxSurvivalRate(x, y, z,1, PA+x.a, PB+x.b);
            int ms2 = maxSurvivalRate(x, y, z, 2, PA+y.a, PB+y.b);
            int ms3 = maxSurvivalRate(x, y, z, 3, PA+z.a, PB+z.b);

            int ms = Math.Max(ms1, Math.Max(ms2, ms3));
        }
        public int maxSurvivalRate(area x, area y, area z,int last, int PA, int PB)
        {
            if(PA<=0 || PB<=0)
            {
                return 0;
            }

            int temp = 0;
            switch(last)
            {
                case 1:
                    temp= 1 + Math.Max(maxSurvivalRate(x, y, z, 2, PA + y.a, PB + y.b), maxSurvivalRate(x, y, z,3 ,PA + z.a, PB + z.b));
                    break;
                case 2:
                    temp = 1 + Math.Max(maxSurvivalRate(x, y, z, 1, PA + x.a, PB + x.b), maxSurvivalRate(x, y, z, 3, PA + z.a, PB + z.b));
                    break;
                case 3:
                    temp = 1 + Math.Max(maxSurvivalRate(x, y, z, 2, PA + y.a, PB + y.b), maxSurvivalRate(x, y, z, 1, PA + x.a, PB + x.b));
                    break;
            }
           // int temp = Math.Max(temp1, Math.Max(temp2, temp3));
            return temp;
        }
    }
    public struct area
    {
        public int a;
        public int b;
        public area(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
