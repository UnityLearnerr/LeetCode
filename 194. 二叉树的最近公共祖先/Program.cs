using System.Collections.Generic;

namespace _194._二叉树的最近公共祖先
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode t5 = new TreeNode(5, null, null);
            TreeNode t1 = new TreeNode(1, null, null);
            TreeNode t9 = new TreeNode(9, t5, t1);

            TreeNode t2 = new TreeNode(2, null, null);
            TreeNode t3 = new TreeNode(3, null, null);
            TreeNode t0 = new TreeNode(0, t2, t3);

            TreeNode t4 = new TreeNode(4, t9, t0);

            TreeNode result = LowestCommonAncestor1(t4, t3, t9);
            Console.WriteLine(result.val);
            Console.ReadLine();
        }

        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || p == root || q == root)
            {
                return root;
            }

            TreeNode l = LowestCommonAncestor(root.left, p, q);
            TreeNode r = LowestCommonAncestor(root.right, p, q);
            if (l == null)
            {
                return r;
            }
            else if (r == null)
            {
                return l;
            }
            else 
            {
                return root;
            }
        }

        public static TreeNode LowestCommonAncestor1(TreeNode root, TreeNode p, TreeNode q)
        {
            Dictionary<TreeNode, TreeNode> parentDic = new Dictionary<TreeNode, TreeNode>();
            parentDic.Add(root, null);
            DPS(root, parentDic);
            HashSet<TreeNode> qParents = new HashSet<TreeNode>();
            TreeNode qParent = q;
            while (qParent != null)
            {
                qParents.Add(qParent);
                qParent = parentDic[qParent];
            }
            TreeNode pParent = p;
            while (pParent != null)
            {
                pParent = parentDic[pParent];
                if (qParents.Contains(pParent)) 
                {
                    return pParent;
                }
            }
            return null;
        }

        public static void DPS(TreeNode root, Dictionary<TreeNode, TreeNode> parentDic) 
        {
            if (root == null) 
            {
                return;
            }
            if (root.left != null) 
            {
                parentDic.Add(root.left, root);
                DPS(root.left, parentDic);
            }
            if (root.right != null) 
            {
                parentDic.Add(root.right, root);
                DPS(root.right, parentDic);
            }
        }
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
