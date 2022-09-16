using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public void testcaseSumII()
        {
            //ascii value of a is 97
            //initial value of char = 96


            //            Given a collection of candidate numbers(candidates) and a target number(target),
            //            find all unique combinations in candidates where the candidate numbers sum to target.

            //Each number in candidates may only be used once in the combination.

            //Note: The solution set must not contain duplicate combinations.
            //        Input: candidates = [10, 1, 2, 7, 6, 1, 5], target = 8
            //Output:
            //            [
            //            [1,1,6],
            //[1,2,5],
            //[1,7],
            //[2,6]
            //]

            LetterCombinations("2342");
                IList<IList<int>> vs = CombinationSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);

        }
        public IList<string> LetterCombinations(string digits)
        {
            Dictionary<int,string> map = new Dictionary<int,string>();
            map.Add(2, "abc");
            map.Add(3, "def");
            map.Add(4, "ghi");
            map.Add(5, "jkl");
            map.Add(6, "mno");
            map.Add(7, "pqrs");
            map.Add(8, "tuv");
            map.Add(9, "wxyz");
            bool[] visited = new bool[digits.Length];
            IList<string> ans = new List<string>();
           // List<string> ds = new List<string>();
            Stack<string> stack = new Stack<string>();  
            dfs(map, digits, 0, stack, ans);
            return ans;
        }
        private void dfs(Dictionary<int,string> map, string digits, int index, Stack<string>ds, IList<string> ans)
        {

            if (index >= digits.Length)
            {
                if(ds.Count == digits.Length)
                {
                    List<string> list = ds.ToList();
                    string s = string.Empty;
                    for (int i = 0; i < digits.Length; i++)
                    {
                        s = list[i] + s;
                    }
                    ans.Add(s);
                }
                return;
            }
            int pos = Convert.ToInt16(digits[index]-'0');
            for (int i = 0; i < map[pos].Length; i++)
            {
                ds.Push(map[pos][i].ToString());
                dfs(map, digits, index + 1, ds, ans);
                ds.Pop();
            }
        }
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            List<int> vs = new List<int>();
            IList<IList<int>> ans = new List<IList<int>>();
            Array.Sort(candidates);
            helper(candidates, target, 0, vs, ans);
            return ans;
        }
        private void helper(int[] c, int t, int index, List<int> ds, IList<IList<int>> ans)
        {
            if (t == 0)
            {
                ans.Add(new List<int>(ds));
                return;
            }
            for (int i = index; i < c.Length; i++)
            {
                if (i > index && c[i] == c[i - 1]) continue;
                else if (c[i] > t) break;
                else if (c[i] <= t)
                {
                    ds.Add(c[i]);
                    helper(c, t - c[i], i + 1, ds, ans);
                    ds.Remove(c[i]);
                }
            }
        }
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<int> vs = new List<int>();
            IList<IList<int>> ans = new List<IList<int>>();
            bt(candidates, target, 0, vs, ans);
            return ans;
        }
        private void bt(int[] c, int t, int index, List<int> ds, IList<IList<int>> ans)
        {
            if (index >= c.Length)
            {
                if (t == 0)
                {
                    ans.Add(new List<int>(ds));
                }
                return;
            }
            if (c[index] <= t)
            {
                ds.Add(c[index]);
                bt(c, t - c[index], index, ds, ans);
                ds.Remove(c[index]);
            }
            bt(c, t, index + 1, ds, ans);
        }
    } 
}
