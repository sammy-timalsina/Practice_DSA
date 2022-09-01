using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LLDs.BillOfMaterials
{
    public abstract class Part
    {
        public abstract double Cost();
        public string itsDescription { get; set; }
    }
}
