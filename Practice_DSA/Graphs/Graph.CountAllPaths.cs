using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Graphs
{
    public partial class Graph
    {
        public int CountPaths(int n, int[][] roads)
        {
            //https://leetcode.com/submissions/detail/794297498/
            int row = roads.Length;
            int destination =n- 1;
            bool[] visited = new bool[n];
            List<int> ds = new List<int>();
            List<GraphPair>[] gp = new List<GraphPair>[row*2];
            for (int i = 0; i < row*2; i++)
            {
                gp[i] = new List<GraphPair>();
            }
            for (int i = 0; i < row; i++)
            {
                gp[roads[i][0]].Add(new GraphPair(roads[i][1], roads[i][2]));
                gp[roads[i][1]].Add(new GraphPair(roads[i][0], roads[i][2]));
            }
            int time = 0;
            dfs(gp, 0, destination, ds, visited,  time);
            ds.Sort();
            int count = 0;
            for(int i=0;i<ds.Count;i++)
            {
                if (ds[i] == ds[0])
                {
                    count++;
                }
                else
                    break;
            }
            return count ;
        }
        public void dfs(List<GraphPair>[] roads, int source, int destination,List<int>ds, bool[]visited,int timeTaken)
        {
            if(source == destination)
            {
                ds.Add(timeTaken);
                return;
            }
            visited[source] = true;
           foreach(GraphPair gp in roads[source])
            {
                if(visited[gp.destination])
                {
                    continue;
                }
                timeTaken = timeTaken + gp.time;
                dfs(roads,gp.destination,destination,ds,visited, timeTaken);
                timeTaken = timeTaken - gp.time;
                visited[gp.destination] = false;
            }
          
        }
    }
}
