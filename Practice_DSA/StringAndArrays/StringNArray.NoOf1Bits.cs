using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.StringAndArrays
{
    public partial class StringNArray
    {
        public int HammingWeight(uint n)
        {
          int count = 0;
          while(n!=0)
            {             
                count = (int) (count + ((n % 2) & 1));
                n/=2;
            }
           return count;
        }
    }
}
