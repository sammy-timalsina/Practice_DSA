using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Recursions
{
    public partial  class Recursion
    {

        public int superDigit(string n, int k)
        {
            //DONT NEED TO CONCAT
            long SUM = getSum(n)*k;
            string str = SUM.ToString();
            int ans = superDigit(str);
            return ans;
        }
        public  int superDigit(string n)
        {
            //base case
            if (n.Length == 1)
                return Convert.ToInt32(n);
            long num = getSum(n); 
            string str = num.ToString();
            return superDigit(str);
        }
        public long getSum(string num)
        {
            long result = 0;
            int ind = 0;
            while(ind < num.Length)
            {
                result = result+ num[ind] - '0';
                ind++;
            }
            return result;
        }
    }
}
