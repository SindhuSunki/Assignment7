using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("apple");
            arrayList.Add("banana");
            arrayList.Add("cherry");
            arrayList.Add("date");
            arrayList.Add("elderberry");
            Console.WriteLine("Total number of elements: " + arrayList.Count);
            bool containsDate = arrayList.Contains("date");
            Console.WriteLine("ArrayList contains 'date': " + containsDate);

            arrayList.Insert(1, "fig");

            arrayList.Remove("banana");

            Console.WriteLine("Elements in the ArrayList:");
            foreach (object element in arrayList)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
    

