using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.StringAndArrays
{
    public partial class StringNArray
    {
        public uint reverseBits(uint n)
        {
           // n = 4294967293;
            string s = ConvertToBinaryString(n);
          
            string revStr = ReveseString(s);
            int rem = 32 - s.Length;
            if (rem > 0)
            {
                for (int k = 0; k < rem; k++)
                {
                    revStr = "0" + revStr;
                }
                s = ReveseString(revStr);
                return ConvertBinaryToDec(s);
            }
            else
            {
                return ConvertBinaryToDec(s);
            }
        }
    }
}
