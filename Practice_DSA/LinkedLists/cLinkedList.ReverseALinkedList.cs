using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LinkedLists
{
    public partial class cLinkedList
    {
        public void testReverseLinkedList()
        {
            ListNode l1 = new ListNode(1, null);
            ListNode l2 = new ListNode(1, null);
            ListNode l3 = new ListNode(2, null);
            ListNode l4 = new ListNode(1, null);
            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            bool ans1=  IsPalindrome(l1);
            ListNode rev= Reverse(l1);
        }
        private ListNode Reverse(ListNode node)
        {
           
            ListNode prev = null;
            ListNode next = null;
            ListNode current = node;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
             node =prev;
            return node;
        }
        public bool IsPalindrome(ListNode head)
        {
            if (head == null) return true;
            else if (head.next == null) return true;
            //Get reversed ListNode
            ListNode original = new ListNode(0,head);
            ListNode rev = reverse(head);
            while (original != null)
            {
                if (rev.val != original.val)
                {
                    return false;
                }
                original = original.next;
                rev = rev.next;
            }
            return true;
        }
        private ListNode reverse(ListNode o)
        {
            ListNode h = o;
            ListNode current = h;
            ListNode prev = null;
            ListNode next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }
    }
}
