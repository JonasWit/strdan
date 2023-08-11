/* Plik przykładowy do rozdziału 5 - Warianty drzew. */

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreeLib;

namespace RedBlackTree
{
    class Program
    {
        static void Main(string[] args)
        {
            RedBlackTreeList<int> tree = new RedBlackTreeList<int>();
            for (int i = 1; i <= 10; i++)
            {
                tree.Add(i);
            }

            tree.Remove(9);

            bool contains = tree.ContainsKey(5);
            Console.WriteLine("Czy wartość istnieje? " + (contains ? "tak" : "nie"));

            uint count = tree.Count;
            tree.Greatest(out int greatest);
            tree.Least(out int least);
            Console.WriteLine($"Liczba elementów: {count}, w zakresie {least}-{greatest}");

            Console.WriteLine("Wartości: " + string.Join(", ", tree.GetEnumerable()));

            Console.Write("Wartości: ");
            foreach (EntryList<int> node in tree)
            {
                Console.Write(node + " ");
            }
        }
    }
}
