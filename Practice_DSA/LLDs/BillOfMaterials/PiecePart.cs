using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LLDs.BillOfMaterials
{
    public class PiecePart : Part
    {
        public PiecePart(double cost)
        {
            itsCost = cost;
        }
        private double itsCost;
        public override double Cost()
        {
            return itsCost;
        }
    }
}
