using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BinaryTrees
{
    public partial class BinaryTree
    {
        public void testCaseLCProblem1022()
        {   //Easy problem
            //You are given the root of a binary tree where each node has a value 0 or 1.
            //Each root - to - leaf path represents a binary number starting with the most significant bit.
            //For example, if the path is 0-> 1-> 1-> 0-> 1, then this could represent 01101 in binary, which is 13.
            //For all leaves in the tree, consider the numbers represented by the path from the root to that leaf.
            //Return the sum of these numbers.
            //The test cases are generated so that the answer fits in a 32 - bits integer.

            //Input: root = [1, 0, 1, 0, 1, 0, 1]
            //Output: 22
            //Explanation: (100) + (101) + (110) + (111) = 4 + 5 + 6 + 7 = 22
            TreeNode root = new TreeNode(1, null, null);
            TreeNode l1 = new TreeNode(0, null, null);
            TreeNode r1 = new TreeNode(1, null, null);
            TreeNode l2 = new TreeNode(0, null, null);
            TreeNode r2 = new TreeNode(1, null, null);
            TreeNode l3 = new TreeNode(0, null, null);
            TreeNode r3 = new TreeNode(1, null, null);
            root.left = l1;
            root.right = r1;
            l1.left = l2;
            l1.right = r2;
            r1.left = l3;
            r1.right = r3;
        //    int sum = SumRootToLeaf(root);
            TreeNode m1 = new TreeNode(0, null, null);
            TreeNode ml1 = new TreeNode(1, null, null);
            TreeNode mr1 = new TreeNode(1, null, null);
            m1.left = ml1;
            m1.right = mr1;
            //test case 3
            TreeNode x1 = new TreeNode(1, null, null);
            //TreeNode xl1 = new TreeNode(1, null, null);
            TreeNode xr1 = new TreeNode(0, null, null);
            //x1.left = xl1;
            x1.right = xr1;
            int sum2 = SumRootToLeaf(x1,0);
        }
        private int SumRootToLeaf(TreeNode root,int sum)
        {
            if(root==null)
            {
                return 0;
            }
            //left shift
            int x = sum << 1;
            int y = root.val;
            int xy = x + y;
            sum =xy;
            if(root.left == null && root.right == null)
            {
                return sum;
            }
            else
            {
                return SumRootToLeaf(root.left, sum) + SumRootToLeaf(root.right, sum);
            }
        }

        private  uint ConvertBinaryToDec(string s)
        {
            int l = s.Length - 1;
            int i = 0;
            uint sum = 0;
            while (l >= 0)
            {
                sum = sum + Convert.ToUInt16(s[i].ToString()) * (uint)Math.Pow(2, l);
                l--;
                i++;
            }
            return sum;
        }
    }
}
