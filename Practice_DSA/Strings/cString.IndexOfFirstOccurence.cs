using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Strings
{
    public partial class cString
    {
        public void testcaseNeedleinAHayStack()
        {
            int ans = StrStr("leetcode", "leeto");
        }
        public int StrStr(string haystack, string needle)
        {
            //first find indexes of first char of needle in haystack
            if (!haystack.Contains(needle))
                return -1;
            List<int> arr = new List<int>();
            for (int i = 0; i < haystack.Length; i++)
            {
                if (needle[0] == haystack[i])
                {
                    arr.Add(i);
                }
            }
            //
            //Check if each indexes on arr matches the string needle
            int index = -1;
            for (int i = 0; i < arr.Count; i++)
            {
                index = arr[i];
                if (index > haystack.Length - needle.Length)
                {
                    break;
                }
                else if (haystack.Substring(index, needle.Length) == needle)
                {
                    return index;
                }
            }
            return -1;
        }
    }
}
