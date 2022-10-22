using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Tries
{
    public partial class cTrie
    {
        public void TestCaseForWordDictionary()
        {
            WordDictionary wt = new WordDictionary();
            wt.AddWord("a");
            wt.AddWord("a");
            bool sr = wt.Search("aa");
            wt.AddWord("mad");
            bool search1 = wt.Search("d..");
            bool search2 = wt.Search("bad");
            bool search3 = wt.Search("d..");
            bool search4 = wt.Search("b..");
        }
    }
    public class WordDictionary
    {
        TrieNode root;
        class TrieNode
        {
            public bool EOL;
            public char currentChar;
            public Dictionary<char, TrieNode> children;
            public TrieNode()
            {
                children = new Dictionary<char, TrieNode>();
            }
        }


        public WordDictionary()
        {
            root = new TrieNode();
        }
        private List<char> getAllDots(TrieNode tree)
        {
            List<char> ds = new List<char>();
            foreach(var kv in tree.children)
            {
                ds.Add(kv.Key);
            }
            return ds;
        }
        public void AddWord(string word)
        {
            //create a dummy node that points to the root node
            TrieNode dummy = root;
            foreach (char c in word)
            {
                if (dummy.children.ContainsKey(c))
                {
                    dummy = dummy.children[c];
                    continue;
                }
                dummy.children.Add(c, new TrieNode());
                dummy.currentChar = c;
                dummy = dummy.children[c];
              
            }
            dummy.EOL = true;
        }

        public bool Search(string word)
        {
            //check if the starting char of word is "."
            TrieNode dummy = root;
            int len = word.Length;
            char c = word[0];
            bool isFound = false;
            if (c == '.')
            {
                List<char> chars = getAllDots(dummy);
                char t;
                foreach(char ch in chars)
                { t = ch;
                    for(int i = 0; i < len;i++)
                    {
                        if (dummy.children.ContainsKey(t))
                        {
                            
                            dummy = dummy.children[t];
                            t = dummy.currentChar;
                        }
                        else
                            break;
                    }
                    if (dummy.EOL)
                    {
                        isFound = true;
                        break;
                    }
                    dummy = root;
                }    
            }
            else
            {
                char t = '.';
                foreach(char ch in word)
                {
                    if(ch== '.')
                    {
                        t = dummy.currentChar;
                    }
                    else
                    {
                        t = ch;
                    }
                    if (dummy.children.ContainsKey(t))
                    {
                        dummy = dummy.children[t];
                    }
                    else
                    {
                      //  isFound = false;
                        return false;
                    }
                }
                isFound = dummy.EOL;
            }
            return isFound;

        }
    }
}
