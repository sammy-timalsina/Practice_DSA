using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Tries
{
    public class cTrie
    {
        TrieNode root;
        public cTrie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            
            TrieNode current = root;
            int ind = 0;
            foreach(char c in word)
            {
                if(!current.children.ContainsKey(c))
                {
                    current.children[c] = new TrieNode();    
                }
                if (ind == word.Length - 1)
                {
                    current.IsEnd = true;
                }
                ind++;
                current = current.children[c];
            }
        }
        public bool Search(string word)
        {
            TrieNode temp = root;
            bool IsEndOfWord = false;
            foreach (char s in word)
            {
                if (temp.children.ContainsKey(s))
                {
                    IsEndOfWord = temp.IsEnd;
                    temp = temp.children[s];
                }
                else
                {
                    return false;
                }
            }
            if (IsEndOfWord)
            {
                return true;
            }
            return false;
        }
        public bool StartsWith(string prefix)
        {
            TrieNode temp = root;
            foreach (char s in prefix)
            {
                if (temp.children.ContainsKey(s))
                {
                    temp = temp.children[s];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class TrieNode
    {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public bool IsEnd = false;
    }
}
