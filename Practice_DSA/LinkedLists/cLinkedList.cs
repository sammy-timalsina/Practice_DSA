using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LinkedLists
{
    public partial class cLinkedList
    {
        public void initializeTestCase()
        {
            TestLeedCodeProblem203RemoveLinkedListElements();
        }
        public void testCase2()
        {
            //-21,10,17,8,4,26,5,35,33,-7,-16,27,-12,6,29,-12,5,9,20,14,14,2,13,-24,21,23,-21,5
            ListNode l1 = new ListNode(-21, null);
            ListNode l2 = new ListNode(10, null);
            ListNode l3 = new ListNode(17, null);
            ListNode l4 = new ListNode(8, null);
            ListNode l5 = new ListNode(4, null);
            ListNode l6 = new ListNode(26, null);
            ListNode l7 = new ListNode(5, null);
            ListNode l8 = new ListNode(35, null);
            ListNode l9 = new ListNode(33, null);
            ListNode l10 = new ListNode(-7, null);
            ListNode l11 = new ListNode(16, null);
            ListNode l12 = new ListNode(27, null);
            ListNode l13 = new ListNode(-12, null);
            ListNode l14 = new ListNode(6, null);
            ListNode l15 = new ListNode(29, null);
            ListNode l16 = new ListNode(-12, null);
            ListNode l17 = new ListNode(6, null);
            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l5;
            l5.next = l6;
            l6.next = l7;
            l7.next = l8;
            l8.next = l9;
            l9.next = l10;
            l10.next = l11;
            l11.next = l12;
            l12.next = l13;
            l13.next = l14;
            l14.next = l15;
            l15.next = l16;
            l16.next = l17;
            HasCycle(l1);
        }
        private void TestLeedCodeProblem203RemoveLinkedListElements()
        {
            //test case 1
            //ListNode l1 = new ListNode(7, null);
            //ListNode l2 = new ListNode(7, null);
            //ListNode l3 = new ListNode(7, null);
            //ListNode l4 = new ListNode(7, null);


            ListNode l1 = new ListNode(6, null);
            ListNode l2 = new ListNode(2, null);
            ListNode l3 = new ListNode(6, null);
            ListNode l4 = new ListNode(3, null);
            ListNode l5 = new ListNode(4, null);
            ListNode l6 = new ListNode(5, null);
            ListNode l7 = new ListNode(6, null);
            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l5;
            l5.next = l6;
            l6.next = l7;
            ListNode ln = RemoveElements(l1, 6);
        }
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
