using System;
using System.Collections.Generic;
using System.IO;

namespace Module3HW1
{
    public class Starter
    {
        public static void Run()
        {
            CustomList<int> list = new CustomList<int>();
            for (int i = 10; i > -1; i--)
            {
                list.Add(i);
            }

            Console.WriteLine("Primary custom list <INT>: " + list + "\n");
            list.Remove(1);
            Console.WriteLine("Remove value \"1\": " + list + "\n");
            list.RemoveAt(0);
            Console.WriteLine("Remove element with index 0: " + list + "\n");
            list.AddRange(new List<int> { 11, 12, 13 });
            Console.WriteLine("Added range: " + list + "\n");
            IEnumerable<int> values = list.Sort();
            var res = string.Empty;
            foreach (int i in values)
            {
                res += i.ToString() + " ";
            }

            Console.WriteLine("Sorted: " + res + "\n");

            var list2 = new CustomList<string>();
            for (int i = 10; i > -1; i--)
            {
                list2.Add("str" + i);
            }

            Console.WriteLine("\nPrimary custom list <STRING>: " + list2 + "\n");
            list2.Remove("str3");
            Console.WriteLine("Remove value \"str3\": " + list2 + "\n");
            list2.RemoveAt(2);
            Console.WriteLine("Remove element with index 2: " + list2 + "\n");
            list2.AddRange(new string[] { "new1", "new2" });
            Console.WriteLine("Added range: " + list2 + "\n");
            IEnumerable<string> values2 = list2.Sort();
            var res2 = string.Empty;
            foreach (string i in values2)
            {
                res2 += i + " ";
            }

            Console.WriteLine("Sorted: " + res2 + "\n");
        }
    }
}
