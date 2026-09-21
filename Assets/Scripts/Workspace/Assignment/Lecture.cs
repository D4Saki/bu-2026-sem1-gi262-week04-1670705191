using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
             LCT01_SyntaxList();
             LCT02_SyntaxLinkedList();
             LCT03_SyntaxHashTable();
             LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            List<string> list = new List<string>();

            list.Add("Item 1");
            list.Add("Item 2");

            foreach (string item in list)
            {
                Debug.Log(item);
            }

            Debug.Log($"Count: {list.Count}");
            if (list.Contains("Item 1"))
            {
                list.Remove("Item 1");
            }
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.AddLast("Node 1");
            list.AddLast("Node 2");
            list.AddFirst("Node 0");

            foreach (string item in list)
            {
                Debug.Log(item);
            }

            LinkedListNode<string> firstNode = list.First;
            LinkedListNode<string> lastNode = list.Last;

            Debug.Log($"First node: {firstNode.Value}");
            Debug.Log($"Last node: {lastNode.Value}");
            Debug.Log($"firstNode.Previous is null: {firstNode.Previous == null}");
            Debug.Log($"lastNode.Next is null: {lastNode.Next == null}");

            LinkedListNode<string> targetNode = list.Find("Node 1");
            if (targetNode != null)
            {
                list.AddBefore(targetNode, "Before Node 1");
                list.AddAfter(targetNode, "After Node 1");
            }

            Debug.Log("After AddBefore & AddAfter:");
            foreach (string item in list)
            {
                Debug.Log(item);
            }

            list.RemoveFirst();
            list.Remove("Node 2");

            Debug.Log("Final list state:");
            foreach (string item in list)
            {
                Debug.Log(item);
            }
        }

        public void LCT03_SyntaxHashTable()
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "Apple");
            ht.Add(2, "Banana");
            ht.Add("bad-fruit", "Rotten Tomato");

            string fruit1 = (string)ht[1];
            string fruit2 = (string)ht[2];
            string badFruit = (string)ht["bad-fruit"];

            Debug.Log($"fruit1: {fruit1}");
            Debug.Log($"fruit2: {fruit2}");
            Debug.Log($"badFruit: {badFruit}");

            foreach (DictionaryEntry entry in ht)
            {
                Debug.Log($"Key: {entry.Key}, Value: {entry.Value}");
            }

            if (ht.ContainsKey(2))
            {
                Debug.Log("found 2");
            }

            ht.Remove(1);

            Debug.Log("After removing key 1:");
            foreach (DictionaryEntry entry in ht)
            {
                Debug.Log($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "Apple");
            dict.Add(2, "Banana");
            dict[3] = "Cherry";

            Debug.Log($"Dictionary has {dict.Count} keys");

            bool hasKey1 = dict.ContainsKey(1);
            Debug.Log($"has key 1 : {hasKey1}");

            if (hasKey1)
            {
                Debug.Log($"value of key 1 : {dict[1]}");
            }

            Debug.Log("All keys in dictionary:");
            foreach (int key in dict.Keys)
            {
                Debug.Log(key);
            }

            dict.Remove(3);

            Debug.Log($"Dictionary has {dict.Count} keys");

            dict.Clear();
        }

        #endregion
    }
}