using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BinarySearches
{

    public partial class BinarySearch
    {
        public void testCaseForCalender()
        {
            //            ["MyCalendarTwo", "book", "book", "book", "book", "book", "book"]
            //[[], [10, 20], [50, 60], [10, 40], [5, 15], [5, 10], [25, 55]]
            Book(10, 20);
            Book(50, 60);
            Book(10, 40);
            Book(5, 15);
            Book(5, 10);
            Book(25, 55);
        }
        SortedDictionary<int, int[]> kv;
        public BinarySearch()
        {
            kv = new SortedDictionary<int, int[]>();
        }
        class Cmp:IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x < y) return 1;
                else if(x > y) return -1;
                else return 0;
               
            }
        }
    }
}
