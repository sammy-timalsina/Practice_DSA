using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public void testCaseForDroneFlightPlanner()
        {
            int[][] route = new int[][] { new int[]{0,   2, 10},
                  new int[]{3,   5,  0},
                  new int[] {9,  20,  6},
                  new int[]{10, 12, 15},
                  new int[]{10, 10,  8} };
            int[,] arr = new int[route.Length,route[0].Length];
            for(int i=0;i<route.Length; i++)
            {
                for(int j=0;j<route[i].Length; j++)
                {
                    arr[i,j] = route[i][j];
                }
            }
            int row = route.Length;
            int col = route[0].Length;
            int totCost = CalcDroneMinEnergy(arr);
        }
        public int CalcDroneMinEnergy(int[,] route)
        {
            // your code goes here
            //step1. extract z axis in separate array element
            int[] ZAxis = new int[route.GetLength(0)];
            for(int i=1; i < route.GetLength(0);i++)
            {
                ZAxis[i] = route[i,2];
            }
            //step 2: Get all the permutations of the number of ZAxis exluding the first index
            List<List<int>> ans = new List<List<int>>();   
            Dictionary<int,int> kv = new Dictionary<int, int>();
            HelperPerm(ZAxis, kv, ans);
            //Step3 : Get the sum from each of the permutate numbers list
            List<int> fuelCost = new List<int>();
            int minVal = int.MaxValue;
            for(int i=0;i<ans.Count;i++)
            {
                int sum = 0;
                for(int j=1;j<ans[0].Count;j++)
                {
                    if(ans[i][j-1]>ans[i][j])
                    {
                        sum+= ans[i][j]-ans[i][j-1];
                    }
                    else if(ans[i][j-1]<ans[i][j])
                    {
                        sum += ans[i][j]- ans[i][j-1];   
                    }
                    else
                    {
                        sum += 0;
                    }
                }
                minVal = Math.Min(sum, minVal);
                fuelCost.Add(sum);
            }
            return Math.Abs(minVal);
        }
        private void HelperPerm(int[]arr, Dictionary<int,int> kv, List<List<int>> vector)
        {
            if(kv.Count == arr.Length-1)
            {
                List<int> vec = kv.Values.ToList();
                vec.Add(10);
                vector.Add(new List<int>(vec));
                return;
            }
            for(int i=1;i<arr.Length;i++)
            {
                if(!kv.ContainsKey(i))
                {
                    kv.Add(i,arr[i]);
                    HelperPerm(arr,kv, vector);
                    kv.Remove(i);
                }
            }
        }

    }
}
