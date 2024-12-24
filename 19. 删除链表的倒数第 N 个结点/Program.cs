using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace _19._删除链表的倒数第_N_个结点
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode root = CreateLinkedList();
            ListNode head = RemoveNthFromEnd(root, 2);
            string str = string.Empty;
            ListNode node = head;
            while (node != null) 
            {
                str += (node.val + ", ");
                node = node.next;
            }
            Console.WriteLine(str);
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode end = head;
            for (int i = 0; i < n; i++) 
            {
                end = end.next;
            }
            if (end == null) // end为空时，说明要删除一个节点
            {
                return head.next;
            }
            ListNode cur = head;
            while (end.next != null) 
            {
                end = end.next;
                cur = cur.next;
            }
            if (cur.next != null)
            {
                cur.next = cur.next.next;
            }
            else 
            {
                cur.next = null;
            }
            return head;
        }

        public static ListNode CreateLinkedList()
        {
            ListNode node1 = new ListNode();
            node1.val = 1;
            ListNode node2 = new ListNode();
            node2.val = 2;
            ListNode node3 = new ListNode();
            node3.val = 3;
            ListNode node4 = new ListNode();
            node4.val = 4;
            ListNode node5 = new ListNode();
            node5.val = 5;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            return node1;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
