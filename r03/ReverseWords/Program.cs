/* Plik przykładowy do rozdziału 3 - Stosy i kolejki. */

using System;
using System.Collections.Generic;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> chars = new Stack<char>();
            foreach (char c in "ODWRÓĆMY!")
            {
                chars.Push(c);
            }

            while (chars.Count > 0)
            {
                Console.Write(chars.Pop());
            }
            Console.WriteLine();
        }
    }
}
