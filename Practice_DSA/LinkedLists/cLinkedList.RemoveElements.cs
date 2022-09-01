using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LinkedLists
{
    public partial class cLinkedList
    {

        private ListNode RemoveElements(ListNode head, int val)
        {
            ListNode temp = head;
            while(temp != null)
            {
                //if first element itself is equal to val
                if(temp.val == val)
                {
                    head= head.next;
                    temp = temp.next;
                    continue;
                }
                //if other elements are equal to val
                else if(temp.next!=null && temp.next.val == val)
                {
                    temp.next = temp.next.next;
                    continue;
                }
                temp = temp.next;
            }
            return head;
        }
    }
}
