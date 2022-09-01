using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BinaryTrees
{
    public partial class BinaryTree
    {
        public void TestCaseIsCousin()
        {
            //Input: root = [1, 0, 1, 0, 1, 0, 1]
            //Output: 22
            //Explanation: (100) + (101) + (110) + (111) = 4 + 5 + 6 + 7 = 22
            TreeNode root = new TreeNode(1, null, null);
            TreeNode l1 = new TreeNode(2, null, null);
            TreeNode r1 = new TreeNode(3, null, null);
            TreeNode l2 = new TreeNode(4, null, null);
            //TreeNode r2 = new TreeNode(7, null, null);

            root.left = l1;
            root.right = r1;
            l1.left = l2;
            //l1.right = r2;
            IsCousins(root, 4, 3);
        }
        public bool IsCousins(TreeNode root, int x, int y)
        {
            //find height of a tree first
            int ht = HtOfaTree(root);
            //look for first level if int x is there
            //if yes return true;
            //caputer index of that level
            //and break from the loop
            int lv = getLevelForRootVal(root, ht, x);
            int rv = getLevelForRootVal(root, ht, y);
            if(Math.Abs(lv-rv)==0)
            {
                return true;
            }
            return false;
        }
        private int getLevelForRootVal(TreeNode root,int ht, int x)
        {
            int lv = -1;
            for (int i = ht; i > 0; i--)
            {
                if (IsCousinsHelper(root, x, i))
                {
                    lv = i;
                    return lv;
                }
            }
            return lv;
        }
        public bool IsCousinsHelper(TreeNode root,int x, int level)
        {
            if(root == null)
            {
                return false;
            }
            if (level == 1 && root.val == x)
            {
                return true;
            }
            else
            {
              return IsCousinsHelper(root.left, x, level - 1)||
                IsCousinsHelper(root.right, x, level - 1);
            }
        }
    }
}
