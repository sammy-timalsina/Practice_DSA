using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.GoogleProblems.cs
{
    public partial class GoogleProblem
    {
        public GoogleProblem()
        {
            testCaseForGP();
        }
        private void testCaseForGP()
        {
            testCaseForCompressedDecompressedString();
        }
        private void testCaseForCompressedDecompressedString()
        {
            char[] ch = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            int ans = Compress(ch);
            string ip = "3[abc]4[ab]c";
            string ip2 = "2[3[a]b]";
            string ip3 = "2[]";
            string ip4 = "3[2[20[2[dog]]cat]cow]";
            string ip5 = "5[2[a]m]";
            string op = getDecompressedString(ip4);
        }
    }
}
