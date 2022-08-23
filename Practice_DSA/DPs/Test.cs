using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.DPs
{
    public class Test
    {
        int r1 = 101;
        int c1 = 101;
        private int[,] t1;
        public Test()
        {
            t1 = new int[r1, c1];
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    t1[i, j] = 0;
                }
            }
        }
        public void getFunction()
        {
            //Prob2.Amazon Academy recently organized a scholarship test on its platform. A total of n students participated in the test.
            //Each student received a unique roll number,i.Each student’s rank is stored at rank[i].Each student gets a unique rank, so the rank is a permutation of values 1 through n.
            //For improved collaboration, the students are to be divided into groups. Use the following rules to find the imbalance in a group of students.
            //A group has k students where 1 <= k <= n.Groups are formed of k students in the ranks with consecutive roll numbers i.e I, (i + 1)..(i + k - 1)
            //The ranks of the students in a group are then sorted ascending to an array, here named  sorted_rank.
            //The imbalance of the group is then defined as the number of students j, who are more than 1 rank
            //beneath the rank of student just ahead of them, i.e sorted_rank[j] – sorted_rank[j - 1] > 1

            int tot = getMinCost(new List<int>() { 4, 3, 2, 6 });
           // int tot = getMinMoves(new int[] { 2,4,3,1 ,6 },5);
            //HashSet<int> hs = new HashSet<int>();
            ////hs.Add(1, 2);
            //Dictionary<int, int> kv = new Dictionary<int, int>();
            //kv.Add(1, 10);
            //kv.Add(100, 2);
            //int y = 0;
            //int x = kv[100];
           // long x =findTotImbalance(new List<int> { 1,5,4});
        }
        private int getMinCost(List<int> list)
        {
            List<int> bk = list;
            List<int> ctr = new List<int>();
            bk.Sort();
            int sum = 0;
            for(int i=0;i<bk.Count;i++)
            {
                sum = bk[0] + bk[1];
                bk.RemoveAt(0);
                bk.RemoveAt(0);
                bk.Add(sum);
                ctr.Add(sum);
                bk.Sort();
            }
            ctr.Add(bk[0] + bk[1]);
            int sum1 = 0;
            for(int i=0;i<ctr.Count;i++)
            {
                sum1 = sum1 + ctr[i];
            }
            return sum1;
        }
        private int getMinMoves(int[] plates, int len)
        {
            Dictionary<int, int> kv = new Dictionary<int, int>();

            int[] bucket = new int[len];
            for (int i = 0; i < len; i++)
            {
                bucket[i] = plates[i];
            }
            Array.Sort(bucket);
            for (int i = 0; i < len; i++)
            {
                kv.Add(bucket[i], i + 1);
            }
            int ptr = 0;
            for (int i = 0; i < len; i++)
            {
                if ((i + 1) != kv[plates[i]])
                {
                    int t1 = plates[i];
                    int pt = kv[plates[i]]-1;
                    plates[i] = plates[pt];
                    plates[pt] = t1;
                    ptr = ptr+1;
                    continue;
                }
                ptr = ptr + 1;
            }
            return ptr;
        }
        public long findTotImbalance(List<int> rank)
        {
            List<int> rk = new List<int>();
            rk = rank;
            rk.Sort();
            long count = 0;
            int diff1 = 0;
            for(int i=0;i<rk.Count;i++)
            {
                for(int j=rk.Count-1;j>=0;j--)
                {
                    diff1 = rk[j] - rk[i];
                    if(diff1 > 1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
