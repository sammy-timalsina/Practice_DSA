using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.SlidingWindows
{
    public partial class SlidingWindow
    {
        public void testCaseForIPAddresses()
        {
            //A valid IP address consists of exactly four integers separated by single dots.
            //Each integer is between 0 and 255(inclusive) and cannot have leading zeros.

            //  For example, "0.1.2.201" and "192.168.1.1" are valid IP addresses, but "0.011.255.245",
            //  "192.168.1.312" and "192.168@1.1" are invalid IP addresses.

            //Given a string s containing only digits, return all possible valid IP addresses that can be formed by inserting dots into s.
            //You are not allowed to reorder or remove any digits in s.You may return the valid IP addresses in any order.
            //Input: s = "25525511135"
            // Output:["255.255.11.135","255.255.111.35"]
            string s = "25525511135";
        }
        public IList<string> RestoreIpAddresses(string s)
        {
            //https://leetcode.com/problems/restore-ip-addresses/
            return null;
        }
    }
}
