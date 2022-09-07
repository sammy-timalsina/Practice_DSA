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
            //step1: find height
            int ht = HtOfaTree(root);
            for(int i=ht;i>0;i--)
            {
                bool IsCousinX = IsCousinOnThisLevel(root, x, ht);
                bool IsCousinY = IsCousinOnThisLevel(root, y, ht);
                if(IsCousinX && IsCousinY)
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsCousinOnThisLevel(TreeNode root, int x, int level)
        {
            if(root == null)
                return false;   
            if (level == 1)
            {
                if (x == root.val)
                {
                    return true;
                }
                return false;
            }
            else
            {
               return IsCousinOnThisLevel(root.left, x, level - 1)||
                IsCousinOnThisLevel(root.right, x, level - 1);
            }
        }
    }
}
