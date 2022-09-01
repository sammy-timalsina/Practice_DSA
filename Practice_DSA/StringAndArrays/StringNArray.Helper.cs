using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.StringAndArrays
{
    public partial class StringNArray
    {
        private static string ReveseString(string s)
        {
            string s1 = string.Empty;
            for (int k = s.Length - 1; k >= 0; k--)
            {
                s1 = s1 + s[k];
            }

            return s1;
        }
        private static string ConvertToBinaryString(uint n)
        {
            uint quo = n;
            string s = string.Empty;
            while (quo != 0)
            {
                s += quo % 2;
                quo = quo / 2;
            }

            return s;
        }
        private static uint ConvertBinaryToDec(string s)
        {
            int l = s.Length - 1;
            int i = 0;
            uint sum = 0;
            while (l >= 0)
            {
                sum = sum + Convert.ToUInt16(s[i].ToString()) * (uint)Math.Pow(2, l);
                l--;
                i++;
            }
            return sum;
        }
    }
}
