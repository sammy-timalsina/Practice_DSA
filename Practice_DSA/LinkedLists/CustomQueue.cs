using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LinkedLists
{
    public class CustomQueue
    {
        public ListNode queue;
        public void enqueue(int val)
        {
            if(queue == null)
                queue = new ListNode(val,null);
            else
            {
                ListNode t = queue;
                while(t.next != null)
                {
                    t = t.next;
                }
                ListNode temp = new ListNode(val,null);
                t.next = temp;
            }
        }
        public int peek()
        {
            return queue.val;
        }
        public int pop()
        {
            int temp = peek();
            queue = queue.next;
            return temp;
        }
    }
}
