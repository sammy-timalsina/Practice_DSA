using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LinkedLists
{
    public partial class cLinkedList
    {
        Node head;
        //
        //Input:
        //LinkedList: 2<->4<->5
        //p = 2, x = 6 
        //Output: 2 4 5 6
        //Explanation: p = 2, and x = 6.So, 6 is
        //inserted after p, i.e, at position 3
        //(0-based indexing).

        //Example 2:

        //Input:
        //LinkedList: 1<->2<->3<->4
        //p = 0, x = 44
        //Output: 1 44 2 3 4
        //Explanation: p = 0, and x = 44.So, 44
        //is inserted after p, i.e, at position 1
        //(0-based indexing).
        //Complete this function
        public void testCaseForAddNode()
        {
          //  Node head = new Node(2);
          //  Node h1 = new Node(4);
          //  Node h2 = new Node(5);
          //  head.next = h1;
          //  head.prev = null;
          //  h1.next = h2;
          //  h1.prev = head;
          //  h2.next = null;
          //  h2.prev = h1;
          ////  addNode(head, 2, 6);
          //  Node head1 = new Node(1);
          //  Node h11 = new Node(2);
          //  Node h22 = new Node(3);
          //  Node h33 = new Node(4);
          //  head1.next = h11;
          //  head1.prev = null;
          //  h11.next = h22;
          //  h11.prev = head1;
          //  h22.next = h33;
          //  h22.prev = h11;
          //  h33.prev = h22;
          //  h33.next = null;

            //addNode(head1, 0, 44);
            addNodeAtFront(23);
            addNodeAtFront(44);
            addNodeAtTail(55);
        }
        public void addNode(Node head, int pos, int data)
        {
            int count = 0;
            Node ptr = head;
            while(ptr != null)
            {
                if(pos == count)
                {
                    Node temp = new Node(data);            
                    temp.next = ptr.next;
                    temp.prev = ptr;
                    ptr.next = temp;
                    break;
                }
                ptr = ptr.next;
                count++;
            }
        }
        //Insertion in DLL:

            //    A node can be added in four ways:

            //At the front of the DLL
            //After a given node.
            //At the end of the DLL
            //Before a given node.

        //at front of the dll
        public void addNodeAtFront(int data)
        {
            Node temp = new Node(data);
            if(head == null)
            {
                head = temp;
            }
            else
            {
                head.prev = temp;
                temp.next = head;
                head = temp;
            }
        }
        public void addNodeAtTail(int data)
        {
            Node temp = new Node(data);
            if(head == null)
            {
                head = temp;
            }
            else
            {
                Node ptr = head;
                while(ptr.next != null)
                {
                    ptr = ptr.next;
                }
                temp.prev = ptr;
                ptr.next = temp;
            }

        }
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node prev;
        public Node(int a)
        {
            this.data = a;
            this.next = null;
            this.prev = null;
        }

    }

}
