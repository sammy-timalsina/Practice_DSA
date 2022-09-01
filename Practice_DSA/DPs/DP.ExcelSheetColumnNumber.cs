using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public int TitleToNumber(string columnTitle)
        {
            int sum = 0;
            int len = columnTitle.Length-1;
            for(int i = 0;i<columnTitle.Length;i++)
            {
                int val = columnTitle[i] - 64;
                sum = sum + val *(int) Math.Pow(26, len);
                len--;
            }
            return sum;
        }
        public int TitleToNumberRec(string columnTitle)
        {
            return TitleToNumberRec(columnTitle, 0, columnTitle.Length);
        }
        private int TitleToNumberRec(string columnTitle, int index, int lenOfStr)
        {
            if(index == columnTitle.Length)
            {
                return 0;
            }
            return (columnTitle[index] - 64) * (int)Math.Pow(26, lenOfStr - 1) 
                + TitleToNumberRec(columnTitle, index + 1, lenOfStr-1);
        }
        public string ConvertToTitle(int columnNumber)
        {
            if (columnNumber <= 26)
            {
                char baseCaseCh = (char)(columnNumber + 64);
                return baseCaseCh.ToString();
            }
            int rem = columnNumber % 26;
            char ch = (char)(64 + rem);
            string s1 = ConvertToTitle(columnNumber / 26);
            return s1 + ch;
        }
    }
}
