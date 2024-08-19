namespace _206.反转链表
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ListNode l1 = new ListNode();
            l1.val = 1;
            ListNode l2 = new ListNode();
            l2.val = 2;
            ListNode l3 = new ListNode();
            l3.val = 3;
            ListNode l4 = new ListNode();
            l4.val = 4;
            ListNode l5 = new ListNode();
            l5.val = 5;

            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l5;
            l5.next = null;

            ListNode n = ReverseList(l1);
            while (n != null) 
            {
                Console.WriteLine(n.val);
                n = n.next;
            }
        }

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null) 
            {
                return null;
            }
            ListNode cur = head;
            ListNode next = head.next;
            head.next = null;
            while (next != null)
            {
                ListNode nn = next.next;
                next.next = cur;
                cur = next;
                next = nn;
            }
            return cur;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
