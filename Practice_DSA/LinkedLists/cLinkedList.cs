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

            l4.next = l5;
            l5.next = l6;
            l6.next = l7;
            ListNode ln = RemoveElements(l1, 6);
        }
        public void testCaseForAddTwoLinkedList()
        {
            ListNode l1 = new ListNode(2, null);
            ListNode l2 = new ListNode(4, null);
            ListNode l3 = new ListNode(3, null);
            l1.next = l2;
            l2.next = l3;

            ListNode r1 = new ListNode(5, null);
            ListNode r2 = new ListNode(6, null);
            ListNode r3 = new ListNode(4, null);
            r1.next = r2;
            r2.next = r3;
            ListNode n1 = new ListNode(3, null);
            ListNode n2 = new ListNode(5, null);
            ListNode n3 = new ListNode(8, null);
            ListNode n4 = new ListNode(10, null);
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            ListNode mm = insertAtSpecificPosition(n1,2, 2);
            int rec=getLengthOFLL(l1);
            int iter =getLengthOFLinkedList(r1);
            AddTwoNumbers(l1, r1);

            //Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
            // Output:[8,9,9,9,0,0,0,1]

            ListNode t1 = new ListNode(9, null);
            ListNode t2 = new ListNode(9, null);
            ListNode t3 = new ListNode(9, null);
            ListNode t4 = new ListNode(9, null);
            ListNode t5 = new ListNode(9, null);
            ListNode t6 = new ListNode(9, null);
            ListNode t7 = new ListNode(9, null);
            t1.next = t2;
            t2.next = t3;
            t3.next = t4;   
            t4.next = t5;
            t5.next = t6;
            t6.next = t7;
            ListNode m1 = new ListNode(9, null);
            ListNode m2 = new ListNode(9, null);
            ListNode m3 = new ListNode(9, null);
            ListNode m4 = new ListNode(9, null);
            m1.next = m2;
            m2.next = m3;
            m3.next = m4;

            AddTwoNumbers(t1, m1);
        }
        public void testCaseForRev()
        {
            ListNode n1 = new ListNode(1, null);
            ListNode n2 = new ListNode(2, null);
            ListNode n3 = new ListNode(3, null);
            ListNode n4 = new ListNode(4, null);
            ListNode n5 = new ListNode(5, null);
            ListNode n6 = new ListNode(6, null);
            ListNode n7 = new ListNode(7, null);
            ListNode n8 = new ListNode(8, null);
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = n6;
            n6.next = n7;
            n7.next = n8;
            ReverseBetween(n1, 1, 8);

            ListNode t1 = new ListNode(1, null);
            ListNode t2 = new ListNode(2, null);
   
            t1.next = t2;
            t2.next = null;
            ReverseBetween(t1, 1, 1);

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
