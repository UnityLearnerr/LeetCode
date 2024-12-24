namespace _104._二叉树的最大深度
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = CreateTree();
            int depth = MaxDepth(root);
            Console.WriteLine(depth);
        }

        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }


        private static TreeNode CreateTree()
        {
            TreeNode node1 = new TreeNode();
            node1.val = 3;
            TreeNode node2 = new TreeNode();
            node2.val = 9;
            TreeNode node3 = new TreeNode();
            node3.val = 20;
            TreeNode node4 = new TreeNode();
            node4.val = 15;
            TreeNode node5 = new TreeNode();
            node4.val = 7;
            node1.left = node2;
            node1.right = node3;
            node3.left = node4;
            node4.right = node5;
            return node1;
        }

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
}
