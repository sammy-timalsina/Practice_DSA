using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BinaryTrees
{
    public partial class BinaryTree
    {
        public void testCaseForPathSum()
        {

            //Other PRoblems
            //https://leetcode.com/problems/binary-tree-paths/
            //https://leetcode.com/problems/path-sum-iii/
            //https://leetcode.com/problems/step-by-step-directions-from-a-binary-tree-node-to-another/
            //Input: root = [1, 0, 1, 0, 1, 0, 1]
            //Output: 22
            //Explanation: (100) + (101) + (110) + (111) = 4 + 5 + 6 + 7 = 22
            TreeNode root = new TreeNode(5, null, null);
            TreeNode l1 = new TreeNode(4, null, null);
   
            TreeNode l2 = new TreeNode(11, null, null);
            TreeNode l3 = new TreeNode(7, null, null);

            TreeNode r4 = new TreeNode(2, null, null);

            TreeNode r1 = new TreeNode(8, null, null);
            TreeNode r2 = new TreeNode(4, null, null);
            TreeNode r3 = new TreeNode(1, null, null);
            TreeNode l4 = new TreeNode(13, null, null);
            TreeNode l5 = new TreeNode(5, null, null);

            root.left = l1;
            l1.left = l2;
            l2.left = l3;
            l2.right = r4;

            root.right = r1;
            r1.right = r2;
            r1.left = l4;
            r2.right = r3;
            r2.left = l5;
           HasPathSum(root, 22);
            PathSum(root, 22);
            TreeNode rm = new TreeNode(-2, null, null);
            TreeNode rr1 = new TreeNode(-3, null, null);
            rm.right = rr1;
            HasPathSum(rm, -5);

            //           TreeNode root = new TreeNode(5, null, null);
            TreeNode rtx = new TreeNode(1, null, null);
            TreeNode lx1 = new TreeNode(-2, null, null);

            TreeNode lx2 = new TreeNode(1, null, null);
           TreeNode lx3 = new TreeNode(-1, null, null);

            TreeNode rx4 = new TreeNode(3, null, null);
            TreeNode rx1 = new TreeNode(-3, null, null);
            TreeNode lx4 = new TreeNode(-2, null, null);
            rtx.left = lx1;
            lx1.left = lx2;
            lx2.left = lx3;
            lx1.right = rx4;

            rtx.right = rx1;
            rx1.left = lx4;
            PathSum(rtx, 2);
        }
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            bool hasPathSum = HasPathSumHelper(root, targetSum,0);
            return hasPathSum;  
        }
        private bool HasPathSumHelper(TreeNode root, int target, int sum)
        {
            if(root == null)
            {
                return false;
            }
            sum = sum + root.val;
            if (sum == target && root.right == null && root.left == null)
            {
                return true;
            }
             
            bool IsNotPathSum =  HasPathSumHelper(root.left, target,  sum) ||
                HasPathSumHelper(root.right, target, sum);
            sum = sum -root.val;
            return IsNotPathSum;
        }
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            IList<IList<int>> ans = new List<IList<int>>(); 
            Dictionary<int,int> kds = new Dictionary<int,int>();
            PathSumHelper(root, targetSum, ans,kds,0, 0);
            return ans;
        }

        private void PathSumHelper(TreeNode root, int target, IList<IList<int>> ans,Dictionary<int,int>kds,int count, int sum)
        {
            if(root == null)
            {
                return;
            }
            sum = sum + root.val;
            count++;
            kds.Add(count, root.val);
            if (sum == target && root.left == null && root.right == null)
            {
                List<int> dds = new List<int>();
                dds  = kds.Select(x=>x.Value).ToList();
                ans.Add(new List<int>(dds));
                kds.Remove(count);
                return;
            }
            PathSumHelper(root.left,target, ans,kds, count,sum);
            PathSumHelper(root.right,target, ans,kds,count,sum);
            sum = sum - root.val;
            kds.Remove(count);

        }
    }
}
