using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Graphs
{
    public partial class Graph
    {
        public void testCaseForCycleDetect()
        {
            List<List<int>> adj = new List<List<int>>
        {
            new List<int>{},
            new List<int>{2},
            new List<int> {3},
            new List<int>{4,6},
            new List<int>{5},
            new List<int>{},
            new List<int>{5},
            new List<int>{2},
            new List<int>{9},
            new List<int>{7}

            };
            List<int> ds = new List<int>();
            bool[] vs = new bool[adj.Count];
            bool isCyclic = false;
            for (int i=0;i<adj.Count;i++)
            {
                if (vs[i]) continue;
                isCycle(adj, i, ds, vs,ref isCyclic);
                if (isCyclic) break;
            }
           // return isCyclic;
        }
        private void isCycle(List<List<int>>adj,int vertex,List<int>ds, bool[]visited, ref bool isCyclic)
        {
            ds.Add(vertex);
            visited[vertex] = true;
            foreach(int i in adj[vertex])
            {
                if (visited[i] && ds.Contains(i))
                {
                    isCyclic = true;
                    return;
                }
                else if (isCyclic) return;
                if(!visited[i])
                    isCycle(adj,i,ds,visited,ref isCyclic);
            }
            ds.Remove(vertex);
        }

    }

}
