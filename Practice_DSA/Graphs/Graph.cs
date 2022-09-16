using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Graphs
{
    public partial class Graph
    {
        public void testCaseForFindKey()
        {
            //[[1,3],[3,0,1],[2],[0]]
            IList<int>[] vs = new List<int>[4];
            vs[0] = new List<int> { 1, 3 };
            vs[1] = new List<int> { 3,0,1 };
            vs[2] = new List<int> { 2 };
            vs[3] = new List<int> { 0};
            CanVisitAllRooms(vs);
        }
        public void testCaseForBFSOfGraph()
        {
            List<int>[] vs = new List<int>[5];
            vs[0] = new List<int> { 1, 2, 3 };
            vs[1] = new List<int> { 1 };
            vs[2] = new List<int> { 4 };
            vs[3] = new List<int>();
            vs[4] = new List<int>();

            List<List<int>> ls = vs.ToList();
            // var ans = bfsOfGraph(5, ls);
            testCaseForNumberOfWaysToArriveAtDestination();
            testCaseForAllSourceToTarget();
        }
        public void testCaseForAllSourceToTarget()
        {
            List<int>[] vs = new List<int>[5];
            vs[0] = new List<int> { 1, 2};
            vs[1] = new List<int> { 3 };
            vs[2] = new List<int> { 3 };
            vs[3] = new List<int>();
            //vs[4] = new List<int>();

            int[][] arr = new int[][]
            {
                vs[0].ToArray(),
                vs[1].ToArray(),
                vs[2].ToArray(),
                vs[3].ToArray()
            };
            var ans = AllPathsSourceTargetDFS(arr);
            //
            List<int>[] bs = new List<int>[6];
            bs[0] = new List<int> { 4,3,1 };
            bs[1] = new List<int> { 3,2,4 };
            bs[2] = new List<int> { 3 };
            bs[3] = new List<int> { 4};
            bs[4] = new List<int>();
            //vs[4] = new List<int>();

            int[][] arr1 = new int[][]
            {
                bs[0].ToArray(),
                bs[1].ToArray(),
                bs[2].ToArray(),
                bs[3].ToArray(),
                bs[4].ToArray()
            };
            ////  [[4,3,1],[3,2,4],[],[4],[]]
            ///
            int[][] arr2 = new int[][]
            {
                new int[]{ 4,3,1 },
                new int[]{ 3,2,4 },
                new int[] { },
                new int[]{4},
                new int[]{}
            };
            var ans1 = AllPathsSourceTargetDFS(arr2);
        }
        public void testCaseForNumberOfWaysToArriveAtDestination()
        {
            //            You are in a city that consists of n intersections numbered from 0 to n -1 with bi-directional roads between some intersections.
            //            The inputs are generated such that you can reach any intersection from any other intersection and that there is at most one road
            //            between any two intersections.

            //You are given an integer n and a 2D integer array roads where roads[i] = [ui, vi, timei] means that there is a road between intersections
            //ui and vi that takes timei minutes to travel.You want to know in how many ways you can travel from intersection 0 to intersection n - 1 in
            //the shortest amount of time.

            //Return the number of ways you can arrive at your destination in the shortest amount of time.
            //Since the answer may be large, return it modulo 109 + 7.

            //        Input: n = 7, roads = [[0, 6, 7],[0,1,2],[1,2,3],[1,3,3],[6,3,3],[3,5,1],[6,5,1],[2,5,1],[0,4,5],[4,6,2]]
            //Output: 4
            //Explanation: The shortest amount of time it takes to go from intersection 0 to intersection 6 is 7 minutes.
            //The four ways to get there in 7 minutes are:
            //-0 ➝ 6
            //- 0 ➝ 4 ➝ 6
            //- 0 ➝ 1 ➝ 2 ➝ 5 ➝ 6
            //- 0 ➝ 1 ➝ 3 ➝ 5 ➝ 6
            int[][] arr = new int[][]
            {
                new int[]{0, 6, 7}, //0
                new int[]{0,1,2},  //1
                new int[]{1,2,3},   //2
                new int[]{1,3,3},   //3
                new int[]{6,3,3},   //4
                new int[]{3,5,1},  //5
                new int[]{6,5,1},   //6
                new int[]{2,5,1},   //7
                new int[]{0,4,5},  //8
                new int[]{4,6,2}   //9
            };
            //make adjacency list
            //0 => (6,7),(1,2), (4,5)
            //1 => (2,3), (3,3),
            //2 => (5,1)

            //CountPaths(7, arr);
            int[][] arr1 = new int[][]
                {
                new int[]{1, 0, 10}
                };

            CountPaths(2, arr1);
        }
    }
    public class GraphPair
    {
        public int destination;
        public int time;
        public GraphPair(int destination, int time)
        {
            this.destination = destination;
            this.time = time;
        }
    }
}
