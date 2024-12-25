namespace _24._两两交换链表中的节点
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head = CreateLinkedList(new int[] { 1, 2, 3});
            ListNode newHead = SwapPairs1(head);
            string str = string.Empty;
            ListNode node = newHead;
            while (node != null)
            {
                str += (node.val + ", ");
                node = node.next;
            }
            Console.WriteLine(str);
        }

        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode next = head.next;
            head.next = SwapPairs(next.next);
            next.next = head;
            return next;
        }

        public static ListNode SwapPairs1(ListNode head)
        {
            if (head == null) 
            {
                return null;
            }
            ListNode result = head.next != null ? head.next : head;
            ListNode node = head;
            while (node != null)
            {
                ListNode cur = node;
                ListNode next = cur.next;
                ListNode nextHead = null;
                ListNode nextNode = null;
                if (next != null) 
                {
                    nextNode = next.next;
                }

                if (next != null)
                {
                    if (next.next != null && next.next.next != null)
                    {
                        nextHead = next.next.next;
                    }
                    else 
                    {
                        nextHead = next.next;
                    }
                }
                if (next != null) 
                {
                    next.next = node;
                }
                cur.next = nextHead;
                node = nextNode;
            }
            return result;
        }


        public static ListNode CreateLinkedList(int[] nums)
        {
            ListNode head = new ListNode();
            head.val = nums[0];
            ListNode lastNode = head;
            for (int i = 1, imax = nums.Length; i < imax; i++)
            {
                ListNode node = new ListNode();
                node.val = nums[i];
                lastNode.next = node;
                lastNode = node;
            }
            return head;
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
