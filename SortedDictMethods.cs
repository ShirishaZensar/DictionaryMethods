using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StockClass
{
    class SortedDictMethods
    {
        static void Main()
        {
            SortedDictionary<int, int> sd = new SortedDictionary<int, int>() {
                                        { 1, 101 },
                                        { 2, 102},
                                        { 3, 103},
                                        { 4, 104} };
            foreach (KeyValuePair<int, int> pair in sd)
                Console.WriteLine("Key: {0} and Value: {1}",
                                      pair.Key, pair.Value);

            Console.WriteLine("Total number of pairs {0}", sd.Count);

            //Checking as equal to itself or not 
            Console.WriteLine(sd.Equals(sd));

            IDictionaryEnumerator ide = sd.GetEnumerator();
            while (ide.MoveNext())
                Console.WriteLine(ide.Key + " --> "+ ide.Value);

            Console.WriteLine("Total key/value pairs in myDict are : " + sd.Count);
            sd.Remove(2);
            Console.WriteLine("After remove operation");
            Console.WriteLine(sd.Count);

            Console.WriteLine("*****Using AsParallel******");
            var ide2 =sd.AsParallel();
            foreach (var item in ide2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*****Using AsQueryable******");
            var ide3 = sd.AsQueryable();
            foreach (var item in ide3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("HashCode as : " +sd.GetHashCode());

        }
    }
}
