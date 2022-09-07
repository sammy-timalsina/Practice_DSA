using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Graphs
{
    public partial class Graph
    {
        List<int> bfsOfGraph(int V, List<List<int>> adj)
        {
            List<int> bucket = new List<int>();
            bool[] visited = new bool[V];
            Queue<List<int>> qu = new Queue<List<int>>();
            qu.Enqueue(adj[0]);
            bucket.Add(0);
            visited[0] = true;
            while (qu.Count > 0)
            {
                List<int> rem = qu.Dequeue();
                foreach (int x in rem)
                {
                    if (visited[x])
                        continue;
                    visited[x] = true;
                    bucket.Add(x);
                    qu.Enqueue(adj[x]);
                }
            }
            return bucket;
        }
    }
}
