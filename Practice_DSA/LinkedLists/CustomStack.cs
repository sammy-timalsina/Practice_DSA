using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LinkedLists
{
    public class CustomStack
    {
        ListNode root;
        public CustomStack()
        {
        }
        public void push(int val)
        {
            if(root==null)
            {
                root = new ListNode(val, null);
                return;
            }
            ListNode temp = new ListNode(val, null);
            temp.next = root;
            root = temp;
            return;
        }
        public int count()
        {
            ListNode head = root;
            int count = 0;
            while(head!=null)
            {
                count++;
                head = head.next;
            }
            return count;
        }
        public int peek()
        {
            if(root!=null)
            {
                return root.val;
            }
            return -1;
        }
        public int pop()
        {
            int val = root.val;
            root = root.next;
            return val;
        }
    }
}
