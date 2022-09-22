using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LRUCaches
{
    public class LRUCache
    {
        internal class Node
        {
            public int key;
            public int val;
            public Node prev;
            public Node next;
            public Node()
            {
                this.prev = null;
                this.next = null;
            }
            public Node(int key, int value)
            {
                this.key = key;
                this.val = value;   
                this.prev = null;
                this.next = null;
            }
        }
        //Design a data structure that follows the constraints of a Least Recently Used(LRU) cache.

        //Implement the LRUCache class:

        //LRUCache(int capacity) Initialize the LRU cache with positive size capacity.
        //int get(int key) Return the value of the key if the key exists, otherwise return -1.
        //void put(int key, int value) Update the value of the key if the key exists.Otherwise, add the key-value pair to the cache.
        //If the number of keys exceeds the capacity from this operation, evict the least recently used key.
        //The functions get and put must each run in O(1) average time complexity.

        //        Example 1:

        //Input
        //["LRUCache", "put", "put", "get", "put", "get", "put", "get", "get", "get"]
        //[[2], [1, 1], [2, 2], [1], [3, 3], [2], [4, 4], [1], [3], [4]]
        //Output
        //[null, null, null, 1, null, -1, null, -1, 3, 4]

        //Explanation
        //LRUCache lRUCache = new LRUCache(2);
        //lRUCache.put(1, 1); // cache is {1=1}
        //lRUCache.put(2, 2); // cache is {1=1, 2=2}
        //lRUCache.get(1);    // return 1
        //lRUCache.put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
        //lRUCache.get(2);    // returns -1 (not found)
        //lRUCache.put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
        //lRUCache.get(1);    // return -1 (not found)
        //lRUCache.get(3);    // return 3
        //lRUCache.get(4);    // return 4
        int size = 0;
        Node head = new Node();
        Node tail = new Node();
        Dictionary<int, Node> map;
        public LRUCache(int capacity)
        {
            size = capacity;
            map = new Dictionary<int, Node>();
            head.next = tail;
            tail.prev = head;
        }

        public int Get(int key)
        {
            return -1;
        }

        public void Put(int key, int value)
        {
            Node node = null;
            if (map.ContainsKey(key))
               node = map[key];
           if(node != null)
            {
                remove(node);
                node.val = value;
                add(node);
            }
           else
            {
                if(map.Count == size)
                {
                    map.Remove(tail.prev.key);
                    remove(tail.prev);
                }
                Node newNode = new Node(key,value);  
                map.Add(key, newNode);
                add(newNode);
            }
        }
        private void add (Node node)
        {
            Node headNext = head.next;
            Node newNode = node;
            newNode.next = headNext;
            newNode.prev = null;
            head = newNode;
        }
        private void remove(Node node)
        {
            Node nextNode = node.next;
            Node prevNode = node.prev;
            nextNode.prev = prevNode;
            prevNode.next = nextNode;
        }
    }
    public class LRUCacheTest
    {
        public LRUCacheTest()
        {
            testCase();
        }
        void testCase()
        {
            LRUCache cache = new LRUCache(2);
            cache.Put(1, 1);
            cache.Put(2, 2);
            int val = cache.Get(1);
            cache.Put(3, 3);
            int g1 = cache.Get(2);
            cache.Put(4, 4);
            int g2 = cache.Get(1);
            int g3 = cache.Get(3);
            int g4 = cache.Get(4);
            //["LRUCache","get","put","get","put","put","get","get"]
            //[[2],[2],[2,6],[1],[1,5],[1,2],[1],[2]]

            //expected
            //[null,-1,null,-1,null,null,2,6]
            LRUCache cache2 = new LRUCache(2);
            int val1 = cache2.Get(2);
            cache2.Put(2, 6);
            int g11 = cache2.Get(1);
            cache2.Put(1, 5);
            cache2.Put(1, 2);
            int g22 = cache2.Get(1);
            int g33 = cache2.Get(2);

            //            ["LRUCache","put","put","put","put","get","get"]
            //[[2],[2,1],[1,1],[2,3],[4,1],[1],[2]]
            LRUCache cache3 = new LRUCache(2);
            cache3.Put(2, 1);
            cache3.Put(1, 1);
            cache3.Put(2, 3);
            cache3.Put(4, 1);
            int x = cache3.Get(1);
            int y = cache3.Get(2);

        }

    }
}
