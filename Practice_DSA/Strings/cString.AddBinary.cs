using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Strings
{
    public partial class cString
    {
        public string AddBinary(string a, string b)
        {
            string revA = String.Empty;
            string revB = String.Empty;
           // int k = 0
            for (int l=a.Length-1;l>=0;l--)
            {
                revA = revA + a[l];
            }
            for (int l = b.Length - 1; l >= 0; l--)
            {
                revB = revB + b[l];
            }
            string rev = string.Empty;
            int i = revA.Length-1;
            int j = revB.Length-1;
            int carry = 0;
            int sum = 0;
            while(i>=0)
            {
                int fnA = revA[i] - '0';
                int fnB = revB[j] - '0';
                int fnC = (fnA << fnB);
             
                sum = fnC % 2 + carry;
                carry = fnC / 2;
                rev = rev + sum;
                i--;j--;
            }
            return rev;
        }
    }
}
