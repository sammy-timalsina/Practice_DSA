using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Tries
{
    public partial class cTrie
    {
        class TrieNode
        {
           public bool EOl;
           public Dictionary<char, TrieNode> childrens = new Dictionary<char, TrieNode>();
        }
        TrieNode root;
        public cTrie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode temp = root;         
            for(int i=0;i<word.Length; i++)
            {
                if (!temp.childrens.ContainsKey(word[i]))
                {
                    temp.childrens.Add(word[i], new TrieNode());
                }
               temp = temp.childrens[word[i]];
            }
            temp.EOl = true; 
        }
        public bool Search(string word)
        {
            TrieNode dummy = root;
            foreach(char c in word)
            {
                if(!dummy.childrens.ContainsKey(c))
                    return false;
                dummy = dummy.childrens[c];
            }
            return dummy.EOl;
        }
        public bool StartsWith(string prefix)
        {
            TrieNode dummy = root;
            foreach(char c in prefix)
            {
                if(!dummy.childrens.ContainsKey(c))
                {
                    return false;
                }
                dummy = dummy.childrens[c];
            }
            return true;
        }
    }

}
