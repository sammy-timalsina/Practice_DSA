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
            int destination = graph.Length - 1;
            int source = 0;
            AllPaths(graph, source,destination, vector, ds,visited);
            return vector;
        }
        private void AllPaths(int[][]graph, int source, int destination, IList<IList<int>> ans, List<int> ds,bool[] visited)
        { 
            ds.Add(source);
            if (source == destination)
            {
                ans.Add(new List<int>(ds));
            }    
            foreach(int item in graph[source])
            {
                if (visited[item])
                    continue;
                visited[item] = true;  
                AllPaths(graph,item,destination,ans,ds,visited);
            }
            ds.Remove(source);
            visited[source] = false;

        }
    }
}
