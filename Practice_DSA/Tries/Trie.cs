using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Tries
{
    public partial class Trie
    {
        Node root;
        public Dictionary<char, Node> children;
        public Trie()
        {
           root = new Node();
           children = new Dictionary<char, Node>();
        }

        public void Insert(string word)
        {
            Node currChildren = root;
            if (root.next == null)
            {
                currChildren.next = new Node();
                currChildren = currChildren.next;
            }
            foreach (char s in word)
            {
               
                currChildren.letter = s;
                currChildren.next = new Node();
                currChildren = currChildren.next;
            }
            currChildren.EndOfLetter = true;
        }

        public bool Search(string word)
        {
            Node temp = root;
            foreach(char s in word)
            {
                if(temp.letter == s)
                {
                    temp = temp.next;
                }
                else
                {
                    return false;
                }
            }
            if(temp.EndOfLetter)
            {
                return true;
            }
            return false;
        }

        public bool StartsWith(string prefix)
        {
            Node temp = root;
            foreach (char s in prefix)
            {
                if (temp.letter == s)
                {
                    temp = temp.next;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class Node
    {
        public char letter;
        public bool EndOfLetter = false;
        public Node next;
        public Node()
        {

        }
        public Node(char letter, Node next)
        {
            this.letter = letter;
            this.next = next;
        }
    }
}
