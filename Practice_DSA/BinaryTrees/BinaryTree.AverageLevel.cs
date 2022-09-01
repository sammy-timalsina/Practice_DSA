using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BinaryTrees
{
    public partial class BinaryTree
    {
        public void TestCaseAverageLevel()
        {
            //Input: root = [1, 0, 1, 0, 1, 0, 1]
            //Output: 22
            //Explanation: (100) + (101) + (110) + (111) = 4 + 5 + 6 + 7 = 22
            TreeNode root = new TreeNode(3, null, null);
            TreeNode l1 = new TreeNode(9, null, null);
            TreeNode r1 = new TreeNode(20, null, null);
            TreeNode l2 = new TreeNode(15, null, null);
            TreeNode r2 = new TreeNode(7, null, null);

            root.left = l1;
            root.right = r1;
            l1.left = l2;
            l1.right = r2;

            AverageOfLevels(root);
        }
        public IList<double> AverageOfLevels(TreeNode root)
        {
            //find average of current level
            //find total count of current level
            List<List<int>> anss = new List<List<int>>();
            int ht = HtOfaTree(root);
            List<double> ans = new List<double>();
            for(int i= ht;i>0;i--)
            {
                double sum = 0;
                int count = 0;
                AverageOfLevelsHelper(root, i, ref sum, ref count);
                ans.Add(sum/count);
            }
            anss.Reverse();
            IList<IList<int>> kk = new List<IList<int>>(anss);
            ans.Reverse();
            IList<double> ans1 = new List<double>(ans);
            return ans1;
        }
        public void AverageOfLevelsHelper(TreeNode root, int level, ref double sum,ref int count)
        {
            if(root == null)
            {
                return;
            }
            if(level==1)
            {
                sum = sum + root.val;
                count = count + 1;
            }
            else if(level > 1)
            {
                AverageOfLevelsHelper(root.left, level-1, ref sum, ref count);
                AverageOfLevelsHelper(root.right, level-1, ref sum, ref count);
            }
        }
    }
}
