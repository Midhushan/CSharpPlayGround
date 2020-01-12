using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("one", 1);
            sortedList.Add("two", 2);
            sortedList.Add("three", 3);
            sortedList.Add("four", 4);

            sortedList.Remove("one");//removes element whose key is 'one'
            sortedList.RemoveAt(0);//removes element at zero index i.e first element: four
            
            foreach (DictionaryEntry kvp in sortedList)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
           


            SortedList list = new SortedList();
            list.Add(1, "one");
            list.Add(2, "two");
            list.Add(3, "three");
            list.Add(4, "four");
            list.Add(5, "five");


            list.Contains(2);
            list.ContainsKey(4);

            foreach(DictionaryEntry mv in list)
            {
                Console.WriteLine("key: {0}, value: {1}", mv.Key, mv.Value);
                Console.ReadKey();
            }
        }
    }
}
