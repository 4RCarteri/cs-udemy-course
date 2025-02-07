using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List
            // Array
            string[] names = new string[3];
            names[0] = "James";
            names[1] = "John";
            names[2] = "Jack";

            string name = names[0];

            // List
            List<string> namesList = new List<string>();
            namesList.Add("James");
            namesList.Add("John");
            namesList.Add("Jack");

            namesList.AddRange(names);
            Console.WriteLine("Names added: " + namesList.Count);

            string nameList = namesList[0];

            if(namesList.Remove("James"))
            {
                Console.WriteLine("James removed");
            }

            if (namesList.Contains("John"))
            {
                Console.WriteLine("John is in the list");
            }

            namesList.Sort();
            Console.WriteLine("Sorted list");

            foreach (string n in namesList)
            {
                Console.WriteLine(n);
            }
            #endregion

            #region HashSet
            Console.WriteLine("\n\n\nHashSet");

            // Duplicates are not allowed
            HashSet<string> namesHashSet = new HashSet<string>();

            namesHashSet.Add("James");
            namesHashSet.Add("John");
            namesHashSet.Add("Jack");

            namesHashSet.Add("James");

            namesHashSet.ElementAt(0);

            foreach (string n in namesHashSet)
            {
                Console.WriteLine(n);
            }
            #endregion

            #region Dictionary
            Console.WriteLine("\n\n\nDictionary");

            // Dictionaries are key-value pairs collection where key is unique and value can be duplicated

            Dictionary<int, string> namesDictionary = new Dictionary<int, string>();

            namesDictionary.Add(1, "James");
            namesDictionary.Add(20, "John");
            namesDictionary.Add(3, "Jack");

            namesDictionary[1] = "James Bond";

            namesDictionary.Remove(2);

            foreach (KeyValuePair<int, string> kvp in namesDictionary)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            #endregion

            #region SortedList
            // SortedList is a collection of key-value pairs where the keys are sorted
            Console.WriteLine("\n\n\nSortedList");

            SortedList<int, string> namesSortedList = new SortedList<int, string>();

            namesSortedList.Add(1, "Poi");
            namesSortedList.Add(20, "John");
            namesSortedList.Add(3, "Abil");

            namesSortedList[1] = "James Bond";

            namesSortedList.Remove(2);

            foreach (KeyValuePair<int, string> kvp in namesSortedList)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            Console.WriteLine("Reverse");

            foreach (KeyValuePair<int, string> kvp in namesSortedList.Reverse())
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            #endregion

            #region SortedDictionary
            // SortedDictionary is a collection of key-value pairs where the keys are sorted

            Console.WriteLine("\n\n\nSortedDictionary");

            SortedDictionary<int, string> namesSortedDictionary = new SortedDictionary<int, string>();

            namesSortedDictionary.Add(1, "Poi");
            namesSortedDictionary.Add(20, "John");
            namesSortedDictionary.Add(3, "Abil");

            namesSortedDictionary[1] = "James Bond";

            namesSortedDictionary.Remove(2);

            foreach (KeyValuePair<int, string> kvp in namesSortedDictionary)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            Console.WriteLine("Reverse");

            foreach (KeyValuePair<int, string> kvp in namesSortedDictionary.Reverse())
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            #endregion

            #region SortedSet
            // SortedSet is a collection of unique elements that are sorted based on their values

            Console.WriteLine("\n\n\nSortedSet");

            SortedSet<string> namesSortedSet = new SortedSet<string>();

            namesSortedSet.Add("Poi");
            namesSortedSet.Add("John");
            namesSortedSet.Add("Abil");

            namesSortedSet.Add("James Bond");

            namesSortedSet.Remove("John");

            foreach (string n in namesSortedSet)
            {
                Console.WriteLine(n);
            }
            #endregion

            #region Queue
            // Queue is a collection of objects that are inserted and removed in FIFO (First In First Out) order

            Console.WriteLine("\n\n\nQueue");

            Queue<string> namesQueue = new Queue<string>();

            namesQueue.Enqueue("Poi");
            namesQueue.Enqueue("John");
            namesQueue.Enqueue("Abil");

            namesQueue.Enqueue("James Bond");

            namesQueue.Dequeue();

            foreach (string n in namesQueue)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("First element:" + namesQueue.Peek());
            #endregion
        }
    }
}
