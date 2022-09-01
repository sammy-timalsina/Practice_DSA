using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BinaryTrees
{
    public partial class BinaryTree
    {
        public void TestCaseForLevelOrderBottom()
        {            //Input: root = [1, 0, 1, 0, 1, 0, 1]
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
            IList<IList<int>> ls =LevelOrderBottom(root);
        }
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            int ht = HtOfaTree(root);
            for(int i=ht;i>0;i--)
            {
                List<int> ds = new List<int>();
                LevelOrderBottom(root, ds, i);
                ans.Add(new List<int>(ds));              
            }
            return ans;
        }

        private void LevelOrderBottom(TreeNode root, List<int> ds,int ht)
        {
            if(root == null)
            {
                return;
            }
           //print current level
           if(ht == 1)
            {
                ds.Add(root.val);
            }
           else if(ht>1)
            {
                LevelOrderBottom(root.left, ds, ht - 1);
                LevelOrderBottom(root.right, ds,  ht - 1);
            }
        }
    }
}
