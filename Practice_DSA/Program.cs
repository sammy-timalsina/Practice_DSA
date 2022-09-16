using Practice_DSA.BackTrackings;
using Practice_DSA.BinaryTrees;
using Practice_DSA.DPs;
using Practice_DSA.GoogleProblems.cs;
using Practice_DSA.Graphs;
using Practice_DSA.Heaps;
using Practice_DSA.LinkedLists;
using Practice_DSA.LRUCaches;
using Practice_DSA.Maps;
using Practice_DSA.Recursions;
using Practice_DSA.SlidingWindows;
using Practice_DSA.Stacks;
using Practice_DSA.StringAndArrays;
using Practice_DSA.Strings;
using Practice_DSA.Tries;
using System;

namespace Practice_DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            LRUCacheTest test = new LRUCacheTest();
          //  googlePRoblems();
           // TrieProblems();
          //  HeapProblems();
           // graphProblems();
            // BinarySearch bs = new BinarySearch();
            //   bs.Search(new int[] { -8,-4,-3, 0, 3, 5, 9, 12,89 },1);
            // SlidingWindowProbs();
            //binary Tree problems
           //   BinaryTreeProblems();
           // LinkedListProblems();
            // StackProblems();
             //  StringProblems();
            // MapProblems();
            //Recursions
          // RecursionProblems();
            //BackTracking
          // BackTrackingProblems();
            // DynamicProgramming();
          //   dynamicProgrammingProblems();
        }
        private static void googlePRoblems()
        {
            GoogleProblem googleProblem = new GoogleProblem();
        }
        private static void TrieProblems()
        {
            cTrie cTrie = new cTrie();
            cTrie.Insert("apple");
            bool a1 = cTrie.Search("apple");
            bool a2 = cTrie.Search("app");
            bool  a3 =cTrie.StartsWith("app");
            cTrie.Insert("app");
            bool a4 =cTrie.Search("app");
            Trie tr = new Trie();
            tr.Insert("apple");
            tr.Insert("car");
            bool srch = tr.Search("apple");
            tr.Insert("appl");
            bool stat = tr.StartsWith("ap");

        }
        private static void HeapProblems()
        {
            Heap h = new Heap();
            h.testCaseForHeapProblems();
        }
        private static void graphProblems()
        {
            Graph graph = new Graph();
            graph.testCaseForFindKey();
            graph.testCaseForBFSOfGraph();
        }
        private static void SlidingWindowProbs()
        {
            SlidingWindow sliding = new SlidingWindow();
            double val = sliding.FindMaxAverage(new int[] { 1, 12, -5, -6, 50, 3 }, 4);
            // sliding.testCaseForMinSwapRequiredToGroupAll1Together();
        }

        private static void BinaryTreeProblems()
        {

            BinaryTree bt = new BinaryTree();
            bt.testCaseForDiameterOfBinaryTree();
            // bt.testCaseForPathSum();
            bt.testCaseForMaxLevelSum();
            bt.TestCaseIsCousin();
            bt.TestCaseAverageLevel();
        }

        private static void LinkedListProblems()
        {
            cLinkedList ll = new cLinkedList();
            ll.testCaseForRev();
            ll.testCaseForDelNthNode();
            ll.testCaseForAddTwoLinkedList();
            ll.testCase2();
            ll.initializeTestCase();
        }

        private static void StackProblems()
        {
            cStack cs = new cStack();
            cs.testCaseForLargestRectangle();
            cs.testCaseForNearestGreaterToRight();
            cs.Push(2);
            cs.Push(5);
            cs.Push(100);
            int topEle = cs.Top();
            int ele = cs.Pop();
            cs.Push(200);
            cs.Push(600);
            int topElem = cs.Top();
        }

        private static void StringProblems()
        {
            cString cString = new cString();
            cString.testcaseNeedleinAHayStack();
            cString.AddBinary("1010", "1011");
            StringNArray str = new StringNArray();
            
            str.testCaseToHex();
            str.testCaseForWordPattern();
            bool fs = str.IsIsomorphic("foo", "bar");
            //  BigInteger bt = BigInteger.Parse("111111111111111111111111101");
            //= 11111111111111111111111111111101;
            str.HammingWeight(11);
            str.reverseBits(43261596);
        }

        private static void MapProblems()
        {
            cMap m = new cMap();
            //[0,1,2,2,3,0,4,2]
            m.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2);
            m.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
        }

        private static void RecursionProblems()
        {
            Recursion rec = new Recursion();
            rec.testCaseForSuperDigit();
            rec.testCaseForProjectEulers();
            rec.testCaseForNumSquares();
            rec.arrangeCoinTestCase();
            int maxV = int.MaxValue - 1;
            bool sta = rec.IsPowerOfTwo(1024);
            int maxVal = int.MaxValue;
            double x1 = 0.00001;
            int n = 2147483647;
            x1 = -1.00000;
            n = -2147483647;
            // double anss = Math.Pow(x1, (double)n);
            double a = rec.MyPow(x1, n);
            var ans = rec.getCombinationSum(new int[] { 2, 3, 6, 7 }, 7);
            //var ans = rec.getAllSubsetsII(new int[]{1,2,2});
            int[] lw = rec.ConstructRectangle(1000);
        }

        private static void dynamicProgrammingProblems()
        {
            DP dp = new DP();
            
            dp.NthUglyNumber(1690);
            dp.testCaseForMaxPRoduct();
            dp.testCaseForLargestRectangleArea();
            int ec = dp.TitleToNumberRec("FXSHRXW");
            string tit = dp.ConvertToTitle(676);

            dp.testGame();
            dp.RodCuttingTestCase();
            dp.IsHappy(2);
            dp.multiplyMatrices();
            dp.getHowmanyways();
            dp.GetMaximumGold();
            // dp.FindMaxiumSquares();
            //dp.minTotalInAtriangle();
            //dp.LengthofLongestIncreSubSeq();
        }



        static void BackTrackingProblems()
        {
            //[["A","B","C","E"],["S","F","E","S"],["A","D","E","E"]]


            BackTrack bt = new BackTrack();
            bt.testcaseSumII();
            bt.testcaseforGameOFLife();
            bt.testcaseForNQueen();
            bt.testCaseForPondSize();
            //bt.PermuteUnique(new int[] { 1, 1, 2 });
            bt.testCaseForDroneFlightPlanner();
            bt.testCaseDepartmentNos();
            bt.testCaseForLexicograph();
            bt.testCaseLargestPerimeter();
            bt.testCaseForSearchSuggestionSystem();
            bt.testCaseForIslands();
            bt.testCaseForFindWords();
            char[][] ch = new char[][] {
                new char[] {'A','B','C','E' },
                new char[] {'S','F','E','S' },
                new char[] {'A','D','E','E' },
            };
            bt.Exist(ch, "ABCESEEEFS");
            bt.SubsetsWithDup(new int[] { 2, 1, 2, 1, 3 });
            bt.Permute(new int[] { 1, 2, 3 });
            //  bt.getAllSums(new List<int> { 1, 1, 2 });
            bt.getNoOfWays();
        }
        public static int Divide(int dividend, int divisor)
        {
            int minVal = int.MinValue;
            int maxVal = int.MaxValue;
            long num = dividend;
            if (divisor == 1 || divisor == -1)
            {
                if (num == minVal && divisor < 0)
                {
                    int x = minVal + 1;
                    return Math.Abs(x);
                }
                else if (num == minVal && divisor > 0)
                {
                    return minVal;
                }
                else if (num == maxVal && divisor < 0)
                {
                    int x = maxVal - 1;
                    return -x;
                }
                else if (num == maxVal && divisor > 0)
                {
                    return maxVal;
                }
            }
            int count = 0;
            bool flagOneSign = false;
            bool flagTwoSign = false;
            if (divisor < 0 && num < 0)
            {
                flagTwoSign = true;
                divisor = Math.Abs(divisor);
                num = Math.Abs(num);
            }
            else if (divisor < 0 || num < 0)
            {
                flagOneSign = true;
                divisor = Math.Abs(divisor);
                num = Math.Abs(num);
            }
            long div = divisor;

            while (div <= num)
            {
                count++;
                div = div + divisor;
            }
            if (flagOneSign)
            {
                return -count;
            }
            else if (flagTwoSign)
            {
                return count;
            }
            else
            {
                return count;
            }
        }
    }
}
