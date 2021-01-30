using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockClass
{
    class Practise 
    {
        static void Main()
        {
            Console.WriteLine("Using simple method");
            int[] arr = new int[5] { 3, 4, 9, 2, 7 };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            var summing= arr.Sum();
            Console.WriteLine(summing);

            Console.WriteLine("copyto");
            int[] num = new int[5];
            arr.CopyTo(num, 0);
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}
