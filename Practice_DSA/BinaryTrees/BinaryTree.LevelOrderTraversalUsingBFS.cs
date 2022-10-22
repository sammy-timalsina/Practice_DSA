using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.BinaryTrees
{
    public partial  class BinaryTree
    {
        public void testCaseForLOT()
        {

            //[8,null,6,null,5,null,4,null,3,null,2,null,1]
            TreeNode h = new TreeNode(8, null, null);
            TreeNode r1 = new TreeNode(6, null, null);
            TreeNode r2 = new TreeNode(4, null, null);
            TreeNode r3 = new TreeNode(3, null, null);
            TreeNode r4 = new TreeNode(2, null, null);
            TreeNode r5 = new TreeNode(2, null, null);
            h.right = r1;
            r1.right = r2;
            r2.right = r3;
            r3.right = r4;  
            r4.right = r5;

            TreeNode clonedd = h;
            TreeNode targett = r2;
            GetTargetCopy(h, clonedd, targett);
            //[7,4,3,null,null,6,19], target = 3
            TreeNode head = new TreeNode(7, null, null);
            TreeNode x1 = new TreeNode(4, null, null);
            TreeNode x2 = new TreeNode(3, null, null);
            TreeNode y1 = new TreeNode(6, null, null);
            TreeNode y2 = new TreeNode(19, null, null);

            head.left = x1;
            head.right = x2;
            x2.left = y1;
            x2.right = y2;

            TreeNode cloned = head;
            TreeNode target = x2;
            GetTargetCopy(head, cloned, target);
            //TreeNode head = new TreeNode(3, null, null);
            //TreeNode x1 = new TreeNode(9, null, null);
            //TreeNode x2 = new TreeNode(20, null, null);
            //TreeNode y1 = new TreeNode(15, null, null);
            //TreeNode y2 = new TreeNode(7, null, null);

            //head.left = x1;
            //head.right = x2;
            //x2.left = y1;
            //x2.right = y2;
            LevelOrder(head);
        }
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            int state= 0;
            dfs(original,ref cloned, target, ref state);
            if (state == 0)
                return cloned.right;

                return cloned.left;
        }
        private void dfs(TreeNode original,ref TreeNode cloned, TreeNode target, ref int state)
        {
            if (original == null || cloned == null) return;

            if (original.left != null && original.left == target)
            {
                state = 1;
                TreeNode dummy = cloned.left;
                cloned = dummy.left;
                return;
            }
            else if (original.right != null && original.right == target)
            {
                state = 0 ;
                TreeNode dummy = cloned.right;
                cloned =dummy;
                return;
            }
                dfs(original.left,ref cloned.left, target, ref state);
                dfs(original.right,ref cloned.right, target, ref state);
        }
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> ls = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                IList<int> list = new List<int>();
                int size = queue.Count;

                for(int i=0;i< size;i++)
                {
                    TreeNode rem = queue.Dequeue();
                    if(rem != null) 
                        list.Add(rem.val);
                    if(rem.left != null) queue.Enqueue(rem.left);
                    if(rem.right != null) queue.Enqueue(rem.right);
                }
                ls.Add(list);
            }
            return ls;
        }
    }
}
