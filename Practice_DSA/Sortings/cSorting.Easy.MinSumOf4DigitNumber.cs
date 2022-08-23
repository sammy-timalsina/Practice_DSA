using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Sortings
{
    public partial class cSorting
    {
        public int MinimumSum(int num)
        {
            //Step1: convert num to strings
            string s1 = num.ToString();
            //Step2 : convert to an array
            List<int> arr = new List<int>();
            for(int i=0;i<s1.Length;i++)
            {
                arr.Add(Convert.ToInt16(s1[i].ToString()));
            }
            //Step3: append first min and first max to string variable
            string num1 = arr.Min().ToString() + arr.Max().ToString();
            arr.Remove(arr.Max());
            arr.Remove(arr.Min());
            //Step4: append second min and second max to another string variable
            string num2 = string.Empty;
            if(arr[0]>arr[1])
            {
                num2 = arr[1].ToString() + arr[0].ToString();
            }
            else
            {
                num2 = arr[0].ToString() + arr[1].ToString();
            }
            return Convert.ToInt16(num1) + Convert.ToInt16(num2);
        }
    }
}
