using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.GoogleProblems.cs
{
    public class Pair
    {
        public char c;
        public int count;

        public Pair(char c, int count)
        {
            this.c = c;
            this.count = count;
        }
    }
    public partial class GoogleProblem
    {
        public int Compress(char[] chars)
        {
            List<Pair> vector = new List<Pair>();
            int count = 1;
            char curr = chars[0];
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == curr)
                {
                    count++;
                    curr = chars[i];
                }
                else
                {
                    vector.Add(new Pair(curr, count));
                    count = 1;
                    curr = chars[i];
                }
            }
            vector.Add(new Pair(curr, count));
            string s = string.Empty;
            for (int i = 0; i < vector.Count; i++)
            {
                Pair p = vector[i];
                if (p.count == 1)
                {
                    s = p.c + s;
                    continue;
                }
                s = s+p.c+ p.count;
            }
            for (int i = 0; i < s.Length; i++)
            {
                chars[i] = s[i];
            }
            return s.Length;
        }
    }
}
