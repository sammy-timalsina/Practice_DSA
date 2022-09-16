﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LRUCaches
{
    public class LRUCache
    {
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


        List<int> ptr;
        Dictionary<int, int> map;
        int size = 0;
        public LRUCache(int capacity)
        {
            size = capacity;
            ptr = new List<int>(capacity);
            map = new Dictionary<int, int>(capacity);
        }

        public int Get(int key)
        {
            if(map.ContainsKey(key))
            {
                if(ptr.Contains(key))
                {
                    ptr.Remove(key);
                    ptr.Add(key);
                    return map[key];
                }
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if(map.Count == 0)
            {
                ptr.Add(key);
                map.Add(key, value);
                return;
            }
            else if(map.Count < size)
            {
                if (map.ContainsKey(key))
                {
                    map[key] = value;
                    if (ptr.Contains(key))
                    {
                        ptr.Remove(key);
                    }
                    ptr.Add(key);
                }
                else
                {
                    ptr.Add(key);
                    map.Add(key, value);
                }
            }
            else if(map.Count == size)
            {
                if(map.ContainsKey(key))
                {
                    map[key] = value;
                    ptr.Remove(key);
                    ptr.Add(key);
                }
                else
                {
                    //remove least recently used
                    map.Remove(ptr[0]);
                    ptr.RemoveAt(0);
                    map.Add(key, value);
                    ptr.Add(key);
                }
            }
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
            int val =cache.Get(1);
            cache.Put(3, 3);
            int g1=cache.Get(2);
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
            int x =cache3.Get(1);
            int y=cache3.Get(2);

        }
    }
}
