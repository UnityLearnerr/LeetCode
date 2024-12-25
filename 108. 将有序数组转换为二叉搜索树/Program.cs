using System.Net.NetworkInformation;

namespace _108._将有序数组转换为二叉搜索树
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return CreateSubTree(nums, 0, nums.Length - 1);
        }

        private static TreeNode CreateSubTree(int[] nums, int left, int right) 
        {
            if (left > right)
            {
                return null;
            }
            int mid = (left + right) / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.left = CreateSubTree(nums, left, mid - 1);
            node.right = CreateSubTree(nums, mid + 1, right);
            return node;
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
