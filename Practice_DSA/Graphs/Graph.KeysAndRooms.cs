using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Graphs
{
    public partial class Graph
    {        
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            bool[] visited = new bool[rooms.Count];
            dfs(rooms, 0,ref visited);
            int count=0;
            for(int i = 0; i<visited.Length; i++)
            {
                if (visited[i])
                    count++;
            }
            if(count==visited.Length)
                return true;
            return false;
        }
        private void dfs(IList<IList<int>> rooms,int nextRoom,ref bool[]visited)
        {
            visited[nextRoom] = true;
            for(int i=0;i<rooms[nextRoom].Count;i++)
            {
                if (visited[rooms[nextRoom][i]])
                    continue;
                visited[rooms[nextRoom][i]] = true;
                dfs(rooms,rooms[nextRoom][i],ref visited);
            }
        }
    }
}
