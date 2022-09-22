using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Maths.cs
{
    public partial class cMath
    {
        public int numberOfSquares(int baseHt)
        {
            //code here
            int baseHalf = baseHt / 2;
            int squares = baseHalf * baseHalf;
            return (squares - baseHalf) / 2;
        }
    }
}
