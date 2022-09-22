using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public partial class DP
    {
        public void testCaseForConvertTime()
        {
            //            You are given two strings current and correct representing two 24 - hour times.

            //24 - hour times are formatted as "HH:MM", where HH is between 00 and 23, and MM is between 00 and 59.The earliest 24 - hour time is 00:00, and the latest is 23:59.

            //In one operation you can increase the time current by 1, 5, 15, or 60 minutes.You can perform this operation any number of times.

            //Return the minimum number of operations needed to convert current to correct.
            //            Example 1:

            //Input: current = "02:30", correct = "04:35"
            //Output: 3
            //Explanation:
            //            We can convert current to correct in 3 operations as follows:
            //-Add 60 minutes to current.current becomes "03:30".
            //- Add 60 minutes to current.current becomes "04:30".
            //- Add 5 minutes to current.current becomes "04:35".
            //It can be proven that it is not possible to convert current to correct in fewer than 3 operations.

            //Example 2:

            //Input: current = "11:00", correct = "11:01"
            //Output: 1
            //Explanation: We only have to add one minute to current, so the minimum number of operations needed is 1.

            string c1 = "02:30"; 
            string c2 = "04:39"; // 120 + 5 => 125 minutes
            ConvertTime(c1, c2);
        }
        public int ConvertTime(string current, string correct)
        {
            string[] str = new string[] {"abc","b","bac","de"};
            
            string[] c1 = current.Split(':');
            string[] c2 = correct.Split(':');
            int currHr = Convert.ToInt16(c1[0]);
            int currMin = Convert.ToInt16(c1[1]);
            int corrHr = Convert.ToInt16(c2[0]);
            int corrMin = Convert.ToInt16(c2[1]);
            int[] arr = new int[] { 1, 5, 15, 60 };
            int corrDifference =   (60 * corrHr + corrMin) - (60 * currHr + currMin);
            int[] values = new int[corrDifference + 1];
            bool[] result = new bool[corrDifference + 1];
            int ans = helperConvertTime(arr, corrDifference, values, result);
            return ans;
        }

        private int helperConvertTime(int[] arr, int target, int[] values, bool[] result)
        {
            if (target == 0) return 0;
            else if (target < 0) return Convert.ToInt32(1E9);
            if (result[target]) return values[target];
            int best = Convert.ToInt32(1E9);
            foreach (int x in arr)
            {
                best = Math.Min(best, 1 + helperConvertTime(arr, target - x, values, result));
            }
            values[target] = best;
            result[target] = true;
            return best;
        }

    }
}
