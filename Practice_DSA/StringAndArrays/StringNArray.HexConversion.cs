using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.StringAndArrays
{
    public partial class StringNArray
    {
        public void testCaseToHex()
        {
            //https://leetcode.com/problems/convert-a-number-to-hexadecimal/
            string hexNum = ToHex(-26);
        }
        public string ToHex(int num)
        {
            string hex = ToHexHelper(num);
            return hex;
        }
        public string ToHexHelper(int num)
        {
            bool IsNeg = false;
            if (num < 0)
            {
                IsNeg = true;
            }
            num = Math.Abs(num);
            int j = 10;
            Dictionary<int, char> map1 = new Dictionary<int, char>();
            Dictionary<char, int> map2 = new Dictionary<char, int>();
            for (int i = 0; i < 16; i++)
            {
                if (i > 9)
                {
                    char c = (char)(97 + (i - j));
                    map1.Add(i, c);
                }
                else
                {
                    string c = i.ToString();
                    map1.Add(i, c[0]);
                }
            }
            List<char> vectors = map1.Values.ToList();
            int k = 15;
            for (int i = 0; i < 16; i++)
            {
                map2.Add(vectors[k], i);
                k--;
            }
            string hex = ConvertToHex(ref num, map1);
            string hexTwoComp = string.Empty;
            if (IsNeg)
            {
                for (int i = 0; i < hex.Length; i++)
                {
                    hexTwoComp = hexTwoComp + map1[map2[hex[i]]];
                }
                for (int i = 0; i < hexTwoComp.Length; i++)
                {
                    int num1 = map2[hexTwoComp[i]];
                }
            }
            return hex;
        }

        private static string ConvertToHex(ref int num, Dictionary<int, char> map1)
        {
            int rem = 0;
            string hex = string.Empty;
            if (num < 16)
            {
                hex = hex + map1[num];

            }
            else
            {
                while (num > 15)
                {
                    rem = num % 16;
                    num = num / 16;
                    hex = hex + num;
                }
                hex = hex + map1[rem];
            }

            return hex;
        }
    }
}
