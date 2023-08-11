/* Plik przykładowy do rozdziału 4 - Słowniki i zbiory. */

using System;
using System.Collections.Generic;

namespace DictionaryUserDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
            employees.Add(100, new Employee() { FirstName = "Marcin", LastName = "Jamro", PhoneNumber = "000-000-000" });
            employees.Add(210, new Employee() { FirstName = "Maria", LastName = "Lis", PhoneNumber = "111-111-111" });
            employees.Add(303, new Employee() { FirstName = "Jan", LastName = "Kowalski", PhoneNumber = "222-222-222" });

            bool isCorrect = true;
            do
            {
                Console.Write("Wprowadź identyfikator pracownika: ");
                string idString = Console.ReadLine();
                isCorrect = int.TryParse(idString, out int id);
                if (isCorrect)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (employees.TryGetValue(id, out Employee employee))
                    {
                        Console.WriteLine(
                            "Imię: {1}{0}Nazwisko: {2}{0}Numer telefonu: {3}",
                            Environment.NewLine,
                            employee.FirstName,
                            employee.LastName,
                            employee.PhoneNumber);
                    }
                    else
                    {
                        Console.WriteLine("Nie ma pracownika o podanym identyfikatorze.");
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            while (isCorrect);
        }
    }
}
