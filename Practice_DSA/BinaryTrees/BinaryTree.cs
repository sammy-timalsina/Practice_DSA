using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BinaryTrees
{
    public partial class BinaryTree
    {
        internal void TestCase1()
        {
            //case1
            //[3,9,20,null,null,15,7]
            //output true
            TreeNode root = new TreeNode(3, null, null);
            TreeNode l1 = new TreeNode(3, null, null);
            TreeNode r1 = new TreeNode(3, null, null);
            TreeNode l2 = new TreeNode(3, null, null);
            TreeNode r2 = new TreeNode(3, null, null);
            root.left = l1;
            root.right = r1;
            r1.left = l2;
            r1.right = r2;
            IsBalanced(root);
            //case 2
            //Input: root = [1, 2, 2, 3, 3, null, null, 4, 4]
            //Output: false
            TreeNode head = new TreeNode(1, null, null);
            TreeNode x1 = new TreeNode(2, null, null);
            TreeNode x2 = new TreeNode(3, null, null);
            TreeNode x3 = new TreeNode(4, null, null);
            TreeNode y1 = new TreeNode(2, null, null);
            TreeNode y2 = new TreeNode(3, null, null);
            TreeNode y3 = new TreeNode(4, null, null);
            head.left = x1;
            x1.left = x2;
            x2.left = x3;
            head.right = y1;
            x1.right = y2;
            x2.right = y3;
            //IsBalanced(head);
            //Testcase 3
            //if only one head is passed
            //test case
            //[1,2,2,3,null,null,3,4,null,null,4]
            TreeNode m1 = new TreeNode(1, null, null);
            TreeNode ml1 = new TreeNode(2, null, null);
            TreeNode ml2 = new TreeNode(3, null, null);
            TreeNode ml3 = new TreeNode(4, null, null);
            TreeNode mr1 = new TreeNode(2, null, null);
            TreeNode mr2 = new TreeNode(3, null, null);
            TreeNode mr3 = new TreeNode(4, null, null);
            m1.left = ml1;
            ml1.left = ml2;
            ml2.left = ml3;
            m1.right = mr1;
            mr1.right = mr2;
            mr2.right = mr3;

            // IsBalanced(m1);
        }
        private int HtOfaTree(TreeNode root)
        {
            if (root == null) return 0;
            return Math.Max(1 + HtOfaTree(root.left), 1 + HtOfaTree(root.right));
        }
    }

    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }


}
