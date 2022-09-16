using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BackTrackings
{
    public partial class BackTrack
    {
        //Department numbers
        //-fire
        //-police
        //-sanitatin

        //Each assigned a number in the range 1-7
        //Fire #, polic #, sanitation #, all different

        //Fire + police + sanitation = 12

        //police must be even
        public void testCaseDepartmentNos()
        {
            List<List<int>> ans = getPerms(1, 7);
        }
        public List<List<int>> getPerms(int rangeStartNum, int rangeEndNum)
        {
            List<List<int>> ans = new List<List<int>>();
            List<int> ds = new List<int>();
            getPerms(rangeStartNum, rangeEndNum, ds, ans);
            return ans;
        }
        public void getPerms(int sn, int en, List<int> ds, List<List<int>> ans)
        {
            if (ds.Count == 3)
            {
                if (ds[0] + ds[1] + ds[2] == 12)
                {
                    if ((ds[0]!=ds[1])&&(ds[0]!=ds[2])&&(ds[1]!=ds[2]))
                    {
                        ans.Add(new List<int>(ds));
                    }
                }
                return;
            }
            for (int i = sn; i <= en; i++)
            {
                if (ds.Count == 2 && ds[1] % 2 != 0)
                {
                    return;
                }
                ds.Add(i);
                getPerms(sn, en, ds, ans);
                ds.Remove(i);
            }          
        }
    }
}
