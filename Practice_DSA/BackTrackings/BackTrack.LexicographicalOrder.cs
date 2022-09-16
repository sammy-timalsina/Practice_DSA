using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        public void testCaseForLexicograph()
        {
            //Design Add and Search Words Data Structure
            getAllLexicographicalNumbers(201);

        }
        public List<int> getAllLexicographicalNumbers(int n)
        {
           List<int> list = new List<int>();
            getNumbers(1,n,list);   
            return list;            
        }
        private void getNumbers(int sv,int n, List<int> ds)
        {
            if (sv > n)
                return;
            ds.Add(sv);
            getNumbers(sv*10,n,ds);
            if(sv%10 != 9)
            {
                getNumbers(sv + 1, n, ds);
            }
        }
    }
}
