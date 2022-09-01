using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BinaryTrees
{
    public partial class BinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if(root == null)
            {
                return true;
            }
            else if(root.left ==null && root.right == null)
            {
                return true;
            }
            int htDiff1 = int.MinValue;
            int htDiff2 = int.MinValue;
            int lf = IsBalancedHelper(root.left,ref htDiff1);
            int rt = IsBalancedHelper(root.right,ref htDiff2);
            if(Math.Abs(lf-rt)<=1 && htDiff1 <= 1 && htDiff2 <= 1 )
            {
                return true;
            }
            return false;
        }
        private int IsBalancedHelper(TreeNode root,ref int htDiff)
        {
            if(root == null)
            {
                return 0;
            }
            int lf = 1 + IsBalancedHelper(root.left,ref htDiff);
            int rt = 1 + IsBalancedHelper(root.right,ref htDiff);
            htDiff = Math.Max(htDiff,Math.Abs(lf - rt));
            int htMax = Math.Max(lf,rt);
            return htMax;
        }
    }
}
