using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {   
        public void testCaseForPondSize()
        {
            int[][] pond = new int[][] { new int[]{0,0,0,0},
                  new int[]{0,0,0,0},
                  new int[] {0,0,0,0},
                  new int[]{0,0,0,0}};
            int[][] vs = new int[][] { new int[] { 0 } };
            getPondSize(vs);
        }
        public List<int> getPondSize(int[][]pond)
        {
            int row = pond.Length;
            int col = pond[0].Length;
            List<int> ds = new List<int>();
            int count = 0;
            bool[,] visited = new bool[row, col];
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    if (!visited[i, j])
                    {
                        count = 0;
                        getPondSize(i, j, pond, ref count,ref visited);
                        if (count > 0)
                        {
                            ds.Add(count);
                        }
                    }
                }
            }
            if(ds.Count == 0)
            {
                return new List<int>();
            }
            return ds;
        }
        private void getPondSize(int i, int j, int[][]pond,ref int count,ref bool[,] visited)
        {
            if(i<0 || j<0 || i>=pond.Length || j >= pond[0].Length)
            {
                return; 
            }
            if(pond[i][j]==0 && !visited[i,j])
            {
                visited[i,j] = true;
                count = count + 1;
                getPondSize(i-1,j-1,pond,ref count,ref visited);
                getPondSize(i-1,j,pond,ref count,ref visited);  
                getPondSize(i-1,j+1,pond,ref count,ref visited);
                getPondSize(i,j-1,pond,ref count,ref visited);
                getPondSize(i,j+1,pond,ref count,ref visited);
                getPondSize(i+1,j-1,pond ,ref count,ref visited);
                getPondSize(i+1,j,pond ,ref count,ref visited);
                getPondSize(i+1,j+1,pond,ref count,ref visited);

            }
            else
            {
                return;
            }
        }
    }
}
