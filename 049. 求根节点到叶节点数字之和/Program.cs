using System.Diagnostics;

namespace _049._求根节点到叶节点数字之和
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = CreateTree();
            int sum = SumNumbers(root);
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        private static TreeNode CreateTree()
        {
            TreeNode t5 = new TreeNode(5, null, null);
            TreeNode t1 = new TreeNode(1, null, null);
            TreeNode t9 = new TreeNode(9, t5, t1);
            TreeNode t0 = new TreeNode(0, null, null);
            TreeNode t4 = new TreeNode(4, t9, t0);
            return t4;
        }

        public static int SumNumbers(TreeNode root)
        {
            int sum = Sum(root, 0);
            return sum;
        }

        private static int Sum(TreeNode node, int preSum) 
        {
            if (node == null)
            {
                return 0;
            }
            int sum = preSum * 10 + node.val;
            if (node.left == null && node.right == null) 
            {
                return sum;
            }
            return Sum(node.left, sum) + Sum(node.right, sum);
        } 

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val, TreeNode left, TreeNode right)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

    }
}
