using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Recursions
{
    public partial class Recursion
    {
        public bool IsPowerOfThree(int n)
        {

            //putting remainder state to -1 initially
            return IsPowerOfThree(n, -1);
        }
        private bool IsPowerOfThree(int n, int rem)
        {
            //checking if n=1 is passed 
            if (n == 1 && rem == -1)
            {
                return true;
            }
            //return false if n is less than zero
            else if (n <= 0)
            {
                return false;
            }
            //if remainder > 0 return false
            else if (rem > 0)
            {
                return false;
            }
            //if it is power of three remainder must be zero and to the last depth it must be 1
            else if (n == 1 && rem == 0)
            {
                return true;
            }
            return IsPowerOfThree(n / 3, n % 3);
        }
        public bool IsPowerOfTwo(int n)
        {
            if(n<=0)
            {
                return false;
            }
            else if(n==1)
            {
                return true;
            }
            return (n%2==0) && IsPowerOfTwo(n / 2);
        }
        public bool CheckPowersOfThree(int n)
        {
            return false;
        }
        private bool CheckPowersOfThree(int n,int ind)
        {
            return false;
        }
    }
}
