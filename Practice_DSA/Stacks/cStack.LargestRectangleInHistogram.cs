using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Stacks
{
    public partial class cStack
    {
        private int LargestRectangleAreaBruteForce(int[] heights)
        {
            int[] area1 = new int[heights.Length];
            int[] area2 = new int[heights.Length];
            int[] area = new int[heights.Length];
            //initialize area1
            for (int i = 0; i < heights.Length; i++)
            {
                area1[i] = heights[i];
            }
            //initialize area2
            for (int i = 0; i < heights.Length; i++)
            {
                area2[i] = heights[i];
            }

            for (int i = 1; i < heights.Length; i++)
            {
                int minHt = 0;
                int minWidth = 0;
                int maxArea = int.MinValue;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (heights[i] <= heights[j])
                    {
                        minHt = Math.Min(heights[i], heights[j]);
                        minWidth = i - j + 1;
                        maxArea = Math.Max(minHt * minWidth, maxArea);
                    }
                    else if (heights[i] > heights[j])
                    {
                        break;
                    }

                }
                area1[i] = Math.Max(maxArea, heights[i]);
            }
            for (int i = 0; i < heights.Length; i++)
            {
                int minHt = 0;
                int minWidth = 0;
                int maxArea = int.MinValue;
                for (int j = i + 1; j < heights.Length; j++)
                {
                    if (heights[i] <= heights[j])
                    {
                        minHt = Math.Min(heights[i], heights[j]);
                        minWidth = j - i + 1;
                        maxArea = Math.Max(minHt * minWidth, maxArea);
                    }
                    else if (heights[i] > heights[j])
                    {
                        break;
                    }

                }
                area2[i] = Math.Max(maxArea, heights[i]);
            }
            int maxArea1 = int.MinValue;
            for (int i = 0; i < heights.Length; i++)
            {
                area[i] = area1[i] + area2[i] - heights[i];
                maxArea1 = Math.Max(maxArea1, area[i]);
            }
            return maxArea1;
        }
        public int LargestRectangleArea(int[] heights)
        {
            Stack<Tuple<int,int>>s =new Stack<Tuple<int,int>>();
            //tuple item1 is index 
            //tuple item2 is value
            //NGR
            int[] bucket1 = new int[heights.Length];
            int[] bucket2 = new int[heights.Length];
            for(int i=heights.Length-1; i>=0; i--)
            {
                if(s.Count ==0)
                {
                    bucket1[i] = -1;
                    s.Push(new Tuple<int,int>(i,heights[i]));
                }
                else if(s.Count > 0 && s.Peek().Item2 < heights[i])
                {
                    bucket1[i] = -1;
                    s.Push(new Tuple<int, int>(i,heights[i]));
                }
                else if(s.Count >0 && s.Peek().Item2 >= heights[i])
                {
                    int ind = -1;
                    while(s.Count > 0)
                    {
                        if (s.Peek().Item2 < heights[i])
                        {
                            break;
                        }
                        ind = s.Peek().Item1;
                        s.Pop();
                    }
                    if(s.Count == 0 || ind != -1 )
                    {
                        bucket1[i] = ind;
                        s.Push(new Tuple<int, int>(ind, heights[i]));
                    }
                }
            }
            s.Clear();
            //Nearest greater to the left NGL
            for(int i=0;i<heights.Length;i++)
            {
                if (s.Count == 0)
                {
                    bucket2[i] = -1;
                    s.Push(new Tuple<int, int>(i, heights[i]));
                }
                else if (s.Count > 0 && s.Peek().Item2 < heights[i])
                {
                    bucket2[i] = -1;
                    s.Push(new Tuple<int, int>(i, heights[i]));
                }
                else if(s.Count > 0 && s.Peek().Item2 >= heights[i])
                {
                    int ind = -1;
                    while(s.Count > 0)
                    {
                        if(s.Peek().Item2 < heights[i])
                        {
                            break;
                        }
                        ind = s.Peek().Item1;
                        s.Pop();
                    }
                   if(s.Count == 0 || ind != -1)
                    {
                        bucket2[i] = ind;
                        s.Push(new Tuple<int, int>(ind,heights[i]));
                    }

                }
            }
            //
            int[] area1 = new int[heights.Length];
            int[] area2 = new int[heights.Length];
            //

            for(int i = 0;i< heights.Length;i++)
            {
                int minHt = 0;
                if(bucket1[i] == -1)
                {
                    area1[i] = heights[i];
                }
                else
                {
                    minHt = Math.Min(heights[i], heights[bucket1[i]]);
                    area1[i] = minHt * (bucket1[i] - i + 1);
                }
            }
            for (int i = 0; i < heights.Length; i++)
            {
                int minHt = 0;
                if (bucket2[i] == -1)
                {
                    area2[i] = heights[i];
                }
                else
                {
                    minHt = Math.Min(heights[i], heights[bucket2[i]]);
                    area2[i] = minHt * (i-bucket2[i] + 1);
                }
            }
            int maxArea1 = int.MinValue;
            int area = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                area = area1[i] + area2[i] - heights[i];
                maxArea1 = Math.Max(maxArea1, area);
            }
            return maxArea1;
        }
    }
}
