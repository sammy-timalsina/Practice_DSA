using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LinkedLists
{
    public partial class cLinkedList
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
            {
                return false;
            }
            ListNode d1 = head;
            ListNode d2 = head;
            while (d1 != null || d2 != null)
            {
                if (d1.next == null || d2.next == null || d2.next.next == null)
                {
                    return false;
                }
                d1 = d1.next;
                d2 = d2.next.next;
                if (d1 == d2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
