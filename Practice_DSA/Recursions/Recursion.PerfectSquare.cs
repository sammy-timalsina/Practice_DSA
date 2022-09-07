using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Recursions
{
    public partial class Recursion
    {
        public void testCaseForPerfectSquare()
        {
              int numMax = int.MaxValue-1;
            int num = 2147395600;
            int num2 = 1024;
             var mm=Math.Sqrt(numMax);
           
            int num3 = 225000000;
           
            //
            int num1 = 2250000;
            IsPerfectSquare(numMax);
            getSquareNumber(numMax);
        }
        public int getSquareNumber(int num)
        {
            int sqrtOfNum = getSquareNumber(num, 1, num);
            return sqrtOfNum;
        }
        public bool IsPerfectSquare(int num)
        {
            int sqrtOfNum = IsPerfectSquareHelper(num,1, num);
            if(sqrtOfNum == -1)
            {
                return false;
            }
            else
                return true;
        }
        public int IsPerfectSquareHelper(int num, int startVal, int endVal)
        {
            //doing this in log n time 
            //using divide and conquer
            long midVal = -1;
            long sqrOfMidVal;

            while (true)
            {
                midVal = startVal + ((endVal - startVal) / 2);
                sqrOfMidVal = midVal * midVal;
                if ((endVal -startVal) < 0)
                {
                    return -1;
                }
                else if (sqrOfMidVal > num)
                {
                    endVal =  (int)midVal-1;
                }
                else if (sqrOfMidVal < num)
                {
                    startVal =(int) midVal+1;
                }
                else if (sqrOfMidVal == num)
                {
                    return (int)midVal;
                }
  
            }
        }
        public int getSquareNumber(int num, int startVal, int endVal)
        {
            //doing this in log n time 
            //using divide and conquer
            int midVal = -1;
            while (true)
            {
                midVal = startVal + ((endVal - startVal) / 2);
                if ((endVal - startVal) < 0)
                {
                    return endVal;
                }
                else if (midVal > (num/midVal))
                {
                    endVal = midVal - 1;
                }
                else if (midVal < (num/midVal))
                {
                    startVal = midVal + 1;
                }
                else if (midVal == num/midVal)
                {
                    return midVal;
                }
            }
        }
    }
}
