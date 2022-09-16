using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LinkedLists
{
    public partial class cLinkedList
    {
        public int getLengthOFLL(ListNode node)
        {
            if(node == null)
                return 0;
            return 1+getLengthOFLL(node.next);
        }
        public int getLengthOFLinkedList(ListNode node)
        {
            int count = 0;
            while(node != null)
            {
                count++;
                node = node.next;
            }
            return count;
        }
        public ListNode insertAtBeginning(ListNode head, int x)
        {
            //Your code here
            ListNode temp = new ListNode();
            temp.val = x;
            temp.next = head;
            head = temp;
            return head;
        }
        public ListNode insertAtSpecificPosition(ListNode head, int position, int x)
        {
            //first find length of LinkedList
            int len = getLengthOFLinkedList(head);
            //create a current node 
            ListNode current = head;
            //create a counter
            int count = 0;
            if(position == 0)
            {
                ListNode temp = new ListNode(x);
                temp.next = head;
                head = temp;
                return head;
            }

            while(current!=null)
            {
                if(position-1 == count)
                {
                    ListNode temp = new ListNode();
                    temp.val=x;
                    temp.next = current.next;
                    current.next = temp;
                }
                current = current.next;
                count++;
            }
            return null;
        }
        public ListNode insertAtEnd(ListNode head, int x)
        {
            //Your code here
            ListNode root = head;
            ListNode temp = new ListNode();
            temp.val = x;
            while(root.next != null)
            {
                root = root.next;
            }
            root.next = temp;
            return head;
        }
    }
}
