using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BinaryTrees
{
    public partial class BinaryTree
    {
        public void testCaseForMaxLevelSum()
        {
            //case1
            //[3,9,20,null,null,15,7]
            //output true
            TreeNode root = new TreeNode(1, null, null);
            TreeNode l1 = new TreeNode(7, null, null);
            TreeNode r1 = new TreeNode(0, null, null);
            TreeNode l2 = new TreeNode(7, null, null);
            TreeNode r2 = new TreeNode(-8, null, null);
            root.left = l1;
            root.right = r1;
            l1.left = l2;
            l1.right = r2;
            MaxLevelSum(root);

            //root = [989,null,10250,98693,-89388,null,null,null,-32127]
            TreeNode rm = new TreeNode(989, null, null);
           // TreeNode lm1 = new TreeNode(7, null, null);
            TreeNode rm1 = new TreeNode(10250, null, null);
            TreeNode lm2 = new TreeNode(98693, null, null);
            TreeNode rm2 = new TreeNode(-89388, null, null);
            TreeNode rm3 = new TreeNode(-32127, null, null);
            rm.right = rm1;
            rm1.left = lm2;
            rm1.right = rm2;
            rm2.right = rm3;
            MaxLevelSum(rm);
            //[1,1,0,7,-8,-7,9]
            TreeNode m = new TreeNode(1, null, null);
             TreeNode ml1 = new TreeNode(1, null, null);
            TreeNode mr1 = new TreeNode(0, null, null);
            TreeNode ml2 = new TreeNode(7, null, null);
            TreeNode mr2 = new TreeNode(-8, null, null);
            TreeNode ml3 = new TreeNode(-7, null, null);
            TreeNode mr3 = new TreeNode(9, null, null);
            m.right = ml1;
            m.left = mr1;
            mr1.right = mr3;
            mr1.left = ml3;
            ml1.left = ml2;
            ml1.right = mr2;

            MaxLevelSum(m);
        }
        public int MaxLevelSum(TreeNode root)
        {
            //find height of a tree first
            int ht = htOFABT(root);
            Dictionary<int,int> map = new Dictionary<int,int>();
            for(int i = ht;i>0;i--)
            {
                int sum = 0;
                SumOFLevel(root, i, ref sum);
                map.Add(i, sum);
            }
            KeyValuePair<int, int> x = map.OrderByDescending(x => x.Value).First();
            int minLevel = int.MaxValue;
            for(int i = ht; i >0; i--)
            {
                if(map[i] ==x.Value)
                {
                    minLevel = Math.Min(i, minLevel);
                }
            }
           return minLevel;
        }
        private void SumOFLevel(TreeNode root, int level, ref int sum)
        {
            if(root==null)
                return;
            if(level == 1)
            {
                sum = sum + root.val;
            }
            else if(level > 1)
            {
                SumOFLevel(root.left, level - 1, ref sum); 
                SumOFLevel(root.right,level-1,ref sum);
            }
        }
        private int htOFABT(TreeNode root)
        {
            if(root == null)
                return 0;
            return Math.Max(1+htOFABT( root.left),1+htOFABT(root.right));
        }
    }

}
