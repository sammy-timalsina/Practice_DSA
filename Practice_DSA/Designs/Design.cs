using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Designs
{
    public partial class Design
    {
       public void testCaseForTimeMap()
        {
            //["TimeMap","set","get","get","set","get","get"]

            //[[],["foo","bar",1],["foo",1],["foo",3],["foo","bar2",4],["foo",4],["foo",5]]
            TimeMap timeMap = new TimeMap();
            timeMap.Set("foo", "bar", 1);
            string ans1= timeMap.Get("foo", 1);
            string ans2 =timeMap.Get("foo", 3);
            timeMap.Set("foo", "bar2", 4);
            string ans3 = timeMap.Get("foo", 4);
            string ans4 = timeMap.Get("foo", 5);

            //second test case

            //[[],["love","high",10],["love","low",20],["love",5],["love",10],["love",15],["love",20],["love",25]]
            TimeMap timeMap2 = new TimeMap();
            timeMap2.Set("love", "high", 10);
            timeMap2.Set("love", "low", 20);
            string ans11 = timeMap2.Get("love", 5);
            string ans22 = timeMap2.Get("love", 10);
           
            string ans33 = timeMap2.Get("love", 15);
            string ans44 = timeMap2.Get("love", 20);
        }
    }
}
