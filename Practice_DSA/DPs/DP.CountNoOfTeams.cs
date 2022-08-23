using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public int NumTeams(int[] rating)
        {
            int[,] dpx1 = new int[50,50];
            for(int i=0;i<50;i++)
            {
                for(int j=0;j<50;j++)
                {
                    dpx1[i, j] =0;
                }
            }
            int num = 3;
            int ltcount = 0;
            int rtCount = 0;
            int totlt = NumTeamsLt(rating, rating.Length, 501,num, ltcount,dpx1);
            int totRt = NumTeamsRt(rating, 0,-1, num, rtCount, dpx1);
            int tot=totlt+totRt;
            return tot;
        }
        private int NumTeamsLt(int[] rating, int index, int prev, int num, int count,int[,] dpx1)
        {
            //base case
            if(index == 0)
            {
                return 0;
            }
            //

            //dont take
            int len = index - 1;
            int donttake = NumTeamsLt(rating, len, index,num,0,dpx1);
            //take
            int take = 0;
            if(rating[len]<prev)
            {
                count++;
                if (count == num)
                {
                    take =1+ NumTeamsLt(rating, len, index, num, 0,dpx1);
                }
                else
                {
                    take = NumTeamsLt(rating, len, index, num, count,dpx1);
                }
            }
          // dpx1[index, prev - 1] = take + donttake;
            return take + donttake;
        }
        private int NumTeamsRt(int[] rating, int index, int prev, int num, int count, int[,] dpx1)
        {
            //base case
            if (index == rating.Length)
            {
                return 0;
            }
            //
            int len = index + 1;
            if (dpx1[len, prev + 1] != -1)
            {
                int val= dpx1[len, prev + 1];
                return val;
            }
            //dont take
        
            int donttake = NumTeamsRt(rating, len, index, num, 0,dpx1);
            //take
            int take = 0;
            if (rating[len-1] > prev)
            {
               count++;
                if (count == num)
                {
                    take = 1 + NumTeamsRt(rating,len, index, num, 0,dpx1);
                }
                else
                {
                    take = NumTeamsRt(rating,len, index, num, count,dpx1);
                }
            }
            dpx1[len, prev + 1] = take + donttake;
            return take + donttake;
        }
    }
}
