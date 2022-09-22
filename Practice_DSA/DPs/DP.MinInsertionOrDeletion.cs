using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public void testcaseForDPMinInsertionAndDeletion()
        {
            string string1 = "heap";
            string string2 = "pea";
            int ans =  getLCS(string1,string2,string1.Length-1,string2.Length-1);
        }
        int getLCS(string s1, string s2, int index1, int index2)
        {
            if (index1 < 0 || index2 < 0)
            {
                return 0;
            }
            else  if(s1[index1]==s2[index2])
            {
               return 1+ getLCS(s1, s2, index1-1, index2-1);
            }
            else
            {
               return Math.Max( getLCS(s1, s2, index1 - 1, index2) , getLCS(s1, s2, index1, index2 - 1));
            }
        }
    }
}
