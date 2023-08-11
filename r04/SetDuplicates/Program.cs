/* Plik przykładowy do rozdziału 4 - Słowniki i zbiory. */

using System;
using System.Collections.Generic;

namespace SetDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Marcin",
                "Maria",
                "Jakub",
                "Albert",
                "Liliana",
                "Emilia",
                "marcin",
                "Jakub",
                "Janina"
            };
            SortedSet<string> sorted = new SortedSet<string>(
                names,
                Comparer<string>.Create((a, b) => a.ToLower().CompareTo(b.ToLower())));
            foreach (string name in sorted)
            {
                Console.WriteLine(name);
            }
        }
    }
}
