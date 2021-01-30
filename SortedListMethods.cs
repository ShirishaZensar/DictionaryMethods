using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockClass
{
    class SortedListMethods
    {
        static void Main()
        {
            SortedList<int, string> sl = new SortedList<int, string>() { 
                                        {3, "Three"},
                                        {5, "Five"},
                                        {1, "One"},
                                        {6, "Five"}
                                    };
            Console.WriteLine("---Initial key:values---");
            foreach (KeyValuePair<int, string> kvp in sl)
                Console.WriteLine(kvp.Key +"-->"+ kvp.Value);

            Console.WriteLine("******Using *******");
            if (sl.ContainsKey(4))
            {
                sl[4] = "four";
            }
            string result;
            if (sl.TryGetValue(4,out result))
                Console.WriteLine("Key: {0}, Value: {1}", 4, result + "\n");

            Console.WriteLine("******Using Count*******");
            for (int i = 0; i < sl.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", sl.Keys[i], sl.Values[i] + "\n");
            }

            Console.WriteLine("******Using Remove*******");
            sl.Remove(1);
            foreach (var kvp in sl)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value + "\n");

            Console.WriteLine("******Using GetEnumerator*******");
            var list5 = sl.GetEnumerator();
            Console.WriteLine("List will be : ");
            while (list5.MoveNext())
            {
                Console.WriteLine(list5.Current);
            }

            Console.WriteLine("******Using IndexofKey*******");
            Console.WriteLine("Index will be: "+ sl.IndexOfKey(2));
        }
    }
}
