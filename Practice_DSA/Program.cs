using Practice_DSA.BackTrackings;
using Practice_DSA.DPs;
using Practice_DSA.Maps;
using Practice_DSA.Recursions;
using Practice_DSA.Sortings;
using Practice_DSA.Stacks;
using Practice_DSA.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Practice_DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<int>> kv = new Dictionary<int,List<int>>();
    
            //Recursions
            RecursionProblems();
            //BackTracking
           // BackTrackingProblems();
            //DynamicProgramming
           // dynamicProgrammingProblems();
        }

        private static void RecursionProblems()
        {
            Recursion rec = new Recursion();
            var ans = rec.getAllSubsetsII(new int[]{1,2,2});
            int[] lw = rec.ConstructRectangle(1000);
        }

        private static void dynamicProgrammingProblems()
        {
            DP dp = new DP();

            string s1 = dp.LCSubStringIter("aacabdkacaa", "aacakdbacaa");
            // int len= dp.LongestCommonSubsequence("abcde", "ace");
        }

        static void BackTrackingProblems()
        {
            BackTrack bt = new BackTrack();
            bt.getAllPerms(new int[] { 1, 2, 3 });
            bt.getAllSums(new List<int> { 5, 2, 1 });
            bt.getNoOfWays();
        }
    }
}
