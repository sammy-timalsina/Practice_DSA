using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LLDs.BillOfMaterials
{
    public class Assembly : Part
    {
        public Assembly()
        {
            parts = new List<Part>();
        }
        private List<Part> parts;
        public override double Cost()
        {
            double cost = 0;
            foreach(var part in parts)
            {
                cost = cost + part.Cost();
            }
            return cost;
        }
    }
}
