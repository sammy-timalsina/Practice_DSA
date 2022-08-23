using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Practice_DSA.Strings
{
    public partial class cString
    {
        public bool IsPalindrome(string s)
        {
            string newStr = System.Text.RegularExpressions.Regex.Replace(s, "[^a-zA-Z0-9]", string.Empty);
            newStr = newStr.ToLower();
            int k = 0;
            int j = newStr.Length - 1;
            while(k < newStr.Length)
            {
                if(newStr[k]!=newStr[j])
                {
                    return false;
                }
                k++;
                j--;
   
            }
            return true;
        }
    }
}
