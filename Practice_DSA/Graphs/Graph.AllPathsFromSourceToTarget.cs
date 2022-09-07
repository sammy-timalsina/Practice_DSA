using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Graphs
{
    public partial class Graph
    {
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            Queue<int[]> qu = new Queue<int[]>();
            IList<IList<int>> vector = new List<IList<int>>();
            IList<int> ds = new List<int>();    
            bool[] visited = new bool[graph.Length];
            qu.Enqueue(graph[0]);
            visited[0] = true;
            ds.Add(0);
            while(qu.Count > 0)
            {
                //remove first
                int[] remArr = qu.Dequeue();    
                foreach(int element in remArr)
                {
                    if(visited[element])
                    {
                        continue;
                    }
                    visited[element] = true;
                    ds.Add(element);
                    qu.Enqueue(graph[element]);
                }
                vector.Add(new List<int>(ds));
            }
            return vector;  

        }
        public IList<IList<int>> AllPathsSourceTargetDFS(int[][] graph)
        {//https://leetcode.com/submissions/detail/793630650/
            IList<IList<int>> vector = new List<IList<int>>();
            List<int> ds = new List<int>();
            bool[] visited = new bool[graph.Length];
            AllPaths(graph, 0, vector, ds,visited, graph.Length-1);
            return vector;
        }
        private void AllPaths(int[][]graph, int source, IList<IList<int>> ans, List<int> ds,bool[] visited, int len)
        {
           if(!visited[source])
            {
                ds.Add(source);
            }
            visited[source] = true;
            for (int i=0; i<graph[source].Length; i++)
            {
                if(visited[graph[source][i]])
                {
                    continue;
                }
               AllPaths(graph, graph[source][i], ans, ds, visited,len);
               visited[graph[source][i]] = false;
            }
            if (graph[source].Length == 0)
            {
                ans.Add(new List<int>(ds));
            }
            ds.Remove(source);
            return;

        }
    }
}
