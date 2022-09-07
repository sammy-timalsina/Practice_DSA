using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Graphs
{
    public partial class Graph
    {
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
            var ans1 = AllPathsSourceTargetDFS(arr1);
        }
    }
}
