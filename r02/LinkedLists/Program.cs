/* Plik przykładowy do rozdziału 2 - Tablice i listy. */

using System;
using System.Collections.Generic;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Page pageFirst = new Page() { Content = "W dzisiejszych czasach istnieją różne (...)" };
            Page pageSecond = new Page() { Content = "Opracowywanie aplikacji jest (...)" };
            Page pageThird = new Page() { Content = "Duża liczba aplikacji (...)" };
            Page pageFourth = new Page() { Content = "Czy wiesz, że nowoczesne (...)" };
            Page pageFifth = new Page() { Content = "Opracowując aplikacje (...)" };
            Page pageSixth = new Page() { Content = "Czy możesz wyobrazić sobie (...)" };

            LinkedList<Page> pages = new LinkedList<Page>();
            pages.AddLast(pageSecond);
            LinkedListNode<Page> nodePageFourth = pages.AddLast(pageFourth);
            pages.AddLast(pageSixth);
            pages.AddFirst(pageFirst);
            pages.AddBefore(nodePageFourth, pageThird);
            pages.AddAfter(nodePageFourth, pageFifth);

            LinkedListNode<Page> current = pages.First;
            int number = 1;
            while (current != null)
            {
                Console.Clear();
                string numberString = $"- {number} -";
                int leadingSpaces = (90 - numberString.Length) / 2;
                Console.WriteLine(numberString.PadLeft(leadingSpaces + numberString.Length));
                Console.WriteLine();

                string content = current.Value.Content;
                for (int i = 0; i < content.Length; i += 90)
                {
                    string line = content.Substring(i);
                    line = line.Length > 90 ? line.Substring(0, 90) : line;
                    Console.WriteLine(line);
                }

                Console.WriteLine();
                Console.WriteLine($"Cytat z książki Marcina Jamry \"Windows Application Development Cookbook\",{Environment.NewLine}Packt Publishing, 2016 r.");

                Console.WriteLine();
                Console.Write(current.Previous != null ? "< POPRZEDNIA [P]" : GetSpaces(16));
                Console.Write(current.Next != null ? "[N] NASTĘPNA >".PadLeft(74) : string.Empty);
                Console.WriteLine();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.N:
                        if (current.Next != null)
                        {
                            current = current.Next;
                            number++;
                        }
                        break;
                    case ConsoleKey.P:
                        if (current.Previous != null)
                        {
                            current = current.Previous;
                            number--;
                        }
                        break;
                    default:
                        return;
                }
            }
        }

        private static string GetSpaces(int number)
        {
            string result = string.Empty;
            for (int i = 0; i < number; i++)
            {
                result += " ";
            }
            return result;
        }
    }
}
