using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LinkedLists
{
    public partial class cLinkedList
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (head == null) return head;
            else if (head.next == null) return head;
            else if (left == right) return head;
            int count = 1;
            ListNode h = head;
            Stack<int> st = new Stack<int>();
            ListNode beforeLeft = new ListNode(-1, null);
            ListNode t1 = beforeLeft;
            ListNode afterRight = new ListNode(-1, null);
            ListNode t2 = afterRight;
            while (h != null)
            {
                if (count < left)
                {
                    t1.next = new ListNode(h.val, null);
                    t1 = t1.next;
                }
                else if (count >= left && count <= right)
                {
                    st.Push(h.val);
                }
                else if (count > right)
                {
                    t2.next = new ListNode(h.val, null);
                    t2 = t2.next;

                }
                h = h.next;
                count++;
            }
            beforeLeft = beforeLeft.next;
            afterRight = afterRight.next;
            ListNode temp = new ListNode(st.Pop(), null);
            ListNode rev = temp;
            while (st.Count > 0)
            {
                ListNode t = new ListNode(st.Pop(), null);
                temp.next = t;
                temp = temp.next;
            }
            if (afterRight == null && beforeLeft == null)
            {
                return rev;
            }
            else if (afterRight != null)
            {
                temp.next = afterRight;
            }
            if (beforeLeft == null)
            {
                temp = rev;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                return rev;
            }
            else
            {
                temp = beforeLeft;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = rev;
                return beforeLeft;
            }
        }
    }
}
