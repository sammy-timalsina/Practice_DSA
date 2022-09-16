using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LinkedLists
{
    public partial class cLinkedList
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            int sumVal = 0;
            ListNode newNode = new ListNode();
            ListNode temp = newNode;
            while(!(l1 == null && l2 == null))
            {
                int num = 0;
                if (l1 == null && l2 != null)
                {
                    num = l2.val + carry;
                    carry = num / 10;
                    sumVal = num % 10;
                    temp.val = sumVal;
                    temp.next = new ListNode();
                    temp = temp.next;
                    l2 = l2.next;
                }
                else if (l1 != null && l2 == null)
                {
                    num = l1.val + carry;
                    carry = num / 10;
                    sumVal = num % 10;
                    temp.val = sumVal;
                    temp.next = new ListNode();
                    temp = temp.next;                   
                    l1 = l1.next;
                }
                else
                {
                    num = l1.val + l2.val + carry;
                    carry = num / 10;
                    sumVal = num % 10;
                    temp.val = sumVal;
                    temp.next = new ListNode();
                    temp = temp.next;
                    l1 = l1.next;
                    l2 = l2.next;
                }              
            }
            if(carry != 0)
            {
                temp.val = carry;
            }
            else
            {
                //Delete the last element
                ListNode t = newNode;
                while(t != null)
                {
                    if(t.next.next == null)
                    {
                        t.next = null;
                        break;
                    }
                    t = t.next;
                }               
            }
            return newNode;
        }
        private ListNode AddTwoNumbers(ListNode l1, ListNode l2,ListNode newNode, int carry)
        {
            if(l1 == null && l2 == null)
                newNode =  null;
            else if(l1 == null && l2 != null)
                newNode= l2;
            else if (l2 == null && l1 != null)
                newNode = l1;


            int num = l1.val + l2.val+ carry;
            carry = num / 10;
            int sumVal = num % 10;

            ListNode curr = newNode;
            ListNode temp = new ListNode();
            temp.val = sumVal;
           // curr.next = new ListNode() ;
            curr.next = temp;
            curr = curr.next;
            AddTwoNumbers(l1.next,l2.next, newNode,carry);
            return newNode;
        }
    }
}
