using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BinaryTrees
{
    public partial class BinaryTree
    {
        public void testCaseForDiameterOfBinaryTree()
        {
            TreeNode root = new TreeNode(3, null, null);
            TreeNode l1 = new TreeNode(1, null, null);
            TreeNode r1 = new TreeNode(2, null, null);
            TreeNode l2 = new TreeNode(4, null, null);
            TreeNode r2 = new TreeNode(5, null, null);
            root.left = l1;
            root.right = r1;
            r1.left = l2;
            r1.right = r2;
            getDiameter(root);
        }
        private int getDiameter(TreeNode root)
        {
            //Brute force way
            List<RootPair> list = new List<RootPair>();
            getDiameter(root, list);
            return list.Count;
        }
        private int getDiameter(TreeNode root, List<RootPair> ds)
        {
            if(root == null)
                return 0;
            //find height of left sub tree
            //find height of right subtree
            //add two heights for each node
            int lf = getDiameter(root.left,ds);
            int rt = getDiameter(root.right,ds);
            int sum = 1+lf + rt;
            ds.Add(new RootPair( sum,root));
            return sum;

        }
    }
    struct RootPair
    {
        public int height;
        public TreeNode tree;
        public RootPair(int height,TreeNode tree)
        {
            this.height = height;
            this.tree = tree;
        }
    }
}
