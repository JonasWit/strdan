/* Plik przykładowy do rozdziału 4 - Słowniki i zbiory. */

using System;
using System.Collections;

namespace HashtablePhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable phoneBook = new Hashtable()
            {
                { "Marcin Jamro", "000-000-000" },
                { "Jan Kowalski", "111-111-111" }
            };

            phoneBook["Liliana Kowalska"] = "333-333-333";
            
            try
            {
                phoneBook.Add("Maria Lis", "222-222-222");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Taki wpis już istnieje.");
            }

            Console.WriteLine("Numery telefonów:");
            if (phoneBook.Count == 0)
            {
                Console.WriteLine("Brak");
            }
            else
            {
                foreach (DictionaryEntry entry in phoneBook)
                {
                    Console.WriteLine($" - {entry.Key}: {entry.Value}");
                }
            }

            Console.WriteLine();
            Console.Write("Szukaj po imieniu i nazwisku: ");
            string name = Console.ReadLine();
            if (phoneBook.Contains(name))
            {
                string number = (string)phoneBook[name];
                Console.WriteLine($"Znaleziono numer telefonu: {number}");
            }
            else
            {
                Console.WriteLine("Nie ma takiego numeru.");
            }
        }
    }
}
