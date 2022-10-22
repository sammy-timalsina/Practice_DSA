namespace Practice_DSA.BinaryTrees
{
    public partial class BinaryTree
    {
        public void testCaseForSumNumbers()
        {
            TreeNode m1 = new TreeNode(4, null, null);
            TreeNode ml1 = new TreeNode(9, null, null);
            TreeNode ml2 = new TreeNode(5, null, null);
            TreeNode ml3 = new TreeNode(1, null, null);
            TreeNode mr1 = new TreeNode(0, null, null);

            m1.left = ml1;
            m1.right = mr1;

            ml1.left = ml2;
            ml1.right = ml3;

            int ans = SumNumbers(m1);
        }
        int prev = 0;
        int sum = 0;
        public int SumNumbers(TreeNode root)
        {
            int count = 0;
            dfs(root, ref count);
            return count;
        }
        void dfs(TreeNode root, ref int count)
        {
            if (root == null) return;
            else if ((root.left == null && root.right == null))
            {
                prev = prev * 10 + root.val;
                count = count + prev;
                prev = prev / 10;
                return;
            }
            prev = prev * 10 + root.val;
            dfs(root.left, ref count);
            dfs(root.right, ref count);
            prev = prev / 10;

        }

    }
}
