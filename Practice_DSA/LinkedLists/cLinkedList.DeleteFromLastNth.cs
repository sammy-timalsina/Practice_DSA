using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LinkedLists
{
    public partial class cLinkedList
    {
        public void testCaseForDelNthNode()
        {
            ListNode n1 = new ListNode(1, null);
            ListNode n2 = new ListNode(2, null);
            ListNode n3 = new ListNode(3, null);
            ListNode n4 = new ListNode(4, null);
            ListNode n5 = new ListNode(5, null);
            //n1.next = n2;
            //n2.next = n3;
            //n3.next = n4;
            //n4.next = n5;
            var node = RemoveNthFromEnd(n1,1);
        }
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            //first calculate length of a head
            int nthPlaceFromFront = lenOFNode(head) - n + 1;
            ListNode curr = head;
            if(nthPlaceFromFront == 1 )
            {
                head = head.next;
                return head;
            }
            else
            {
                int count = 1;
                while(curr != null)
                {
                    if(count == nthPlaceFromFront-1)
                    {
                        curr.next = curr.next.next;
                        break;
                    }
                    curr = curr.next;
                    count++;
                }
                return head;
            }
        }
        private int lenOFNode(ListNode head)
        {
            if(head == null) return 0;
            return 1+lenOFNode(head.next);
        }
    }
}
