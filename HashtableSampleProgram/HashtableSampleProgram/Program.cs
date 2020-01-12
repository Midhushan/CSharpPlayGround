using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableSampleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add(3, "three");
            ht.Add(4, "four");
            ht.Add("fv", "five");

            string value1 = (string)ht[2];
            string value2 = (string)ht[3];

            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine("Key : {0} Value : {1}", item.Key, item.Value);
            }

            Console.WriteLine("elements : {0} {1}", value1, value2);

            Console.WriteLine("No of elements : {0} {1}", ht.Count, ht.Contains(3));
            Console.ReadKey();


            //foreach(Dictionary ad in ht)
            //{

            //}
        }
    }
}
