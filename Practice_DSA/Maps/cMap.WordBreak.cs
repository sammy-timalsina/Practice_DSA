using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Maps
{
    public partial class cMap
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            //sort the array
            Array.Sort(nums); // O(N)Log(N)
            int minVal = (int)1E9;
            int closestSum = (int)1E9;
            for (int i = 0; i < nums.Length; i++)
            {
                int find = target - nums[i];
                //use two pointers
                int start = i + 1;
                int end = nums.Length - 1;
                while (start < end)
                {
                    int curr = nums[start] + nums[end];
                    int distanceFromTarget = Math.Abs(find - curr);
                    if (distanceFromTarget <= minVal)
                    {
                        closestSum = nums[i] + curr;
                        minVal = Math.Min(minVal, distanceFromTarget);
                    }
                    if (curr < find)
                        start++;
                    else if (curr >= find)
                        end--;

                }
            }
            return closestSum;
        }
        public void testCaseForWordBreak()
        {
            int[] arr = new int[] { -1,2,1,-4 };
            ThreeSumClosest(arr, 1);
            // s = "applepenapple", wordDict = ["apple","pen"]
            string s1 = "aaaaaaa";
            IList<string> words1 = new List<string>() { "aaa","aaaa"};
            bool ans2= WordBreak(s1, words1);  
            string s = "applepenapple";
            IList<string> words = new List<string>() { "apple","pen"};
            bool ans = WordBreak(s,words);  
        }
        public bool WordBreak(string s, IList<string> wordDict)
        {
            //key is a dictionary word, and value is the occurences of the word
            //if value of word is zero return false
            Cmp cmp = new Cmp();
           Dictionary<string, int> map = new Dictionary<string, int>();
            for (int i = 0; i < wordDict.Count; i++)
            {
                map.Add(wordDict[i], wordDict[i].Length);
            }
            string str = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                //check if the substring is in dictionary
                str = str + s[i];
                if (map.ContainsKey(str))
                {
                    str = string.Empty;
                }
            }
            if (str == string.Empty)
                return true;
            return false;
        }
        class Cmp : IComparer<string>
        {
            public int Compare(string a, string b)
            {
                if (a.Length > b.Length) return a.Length;
                else if (a.Length < b.Length) return b.Length;
                else return 0;
            }
        }
    }
}
