/* Plik przykładowy do rozdziału 4 - Słowniki i zbiory. */

using System;
using System.Collections.Generic;

namespace DictionaryDefinitions
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> definitions = new SortedDictionary<string, string>();
            do
            {
                Console.Write("Wybierz opcję ([d] - dodaj, [l] - listuj): ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();
                if (keyInfo.Key == ConsoleKey.D)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Wprowadź nazwę: ");
                    string name = Console.ReadLine();
                    Console.Write("Wprowadź objaśnienie: ");
                    string explanation = Console.ReadLine();
                    definitions[name] = explanation;
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (keyInfo.Key == ConsoleKey.L)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (KeyValuePair<string, string> definition in definitions)
                    {
                        Console.WriteLine($"{definition.Key}: {definition.Value}");
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Czy chcesz wyjść z programu? Naciśnij [t] (tak) lub [n] (nie).");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (Console.ReadKey().Key == ConsoleKey.T)
                    {
                        break;
                    }
                }
            }
            while (true);
        }
    }
}
