using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Designs
{
    public partial class TimeMap
    {
        Dictionary<string, List<Tuple<int, string>>> map;
        public TimeMap()
        {
            map = new Dictionary<string, List<Tuple<int, string>>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            if (map.ContainsKey(key))
            {
                map[key].Add(new Tuple<int, string>(timestamp, value));
            }
            else
            {
                Tuple<int, string> set = new Tuple<int, string>(timestamp, value);
                map.Add(key, new List<Tuple<int, string>>() { set });
            }
        }

        public string Get(string key, int timestamp)
        {
            if (map.ContainsKey(key))
            {
                return binarySearch(map[key],map[key].Count, timestamp);
            }
            return "";
        }
        private string binarySearch(List<Tuple<int,string>> ls, int size, int element)
        {
            int start = 0;
            int end = size - 1;
            string ans = string.Empty;
            while(start<= end)
            {
                int mid = (start+end)/2;    
                if(ls[mid].Item1 == element)
                {
                    ans= ls[mid].Item2;
                    break;
                }
                else if(ls[mid].Item1 < element)
                {
                    ans = ls[mid].Item2;
                    start = mid + 1;
                }
                else if(ls[mid].Item1 > element)
                {
                    end = mid - 1;
                }
            }
            return ans;
        }
    }
}
