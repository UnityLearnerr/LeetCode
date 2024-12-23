namespace _142._环形链表_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head = CreateLinkList();
            ListNode result = DetectCycle(head);
            Console.WriteLine(result.val);
        }

        public static ListNode DetectCycle(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;

            while (fast != null && slow != null)
            {
                slow = slow.next;
                if (fast.next != null)
                {
                    fast = fast.next.next;
                }
                else
                {
                    return null;
                }
                if (fast == slow)
                {
                    ListNode ptr = head;
                    while (ptr != fast)
                    {
                        ptr = ptr.next;
                        fast = fast.next;
                    }
                    return ptr;
                }
            }

            return null;
        }

        private static ListNode CreateLinkList()
        {
            ListNode node1 = new ListNode(3);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(0);
            ListNode node4 = new ListNode(-4);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node2;
            return node1;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
    }
}