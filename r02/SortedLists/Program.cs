﻿/* Plik przykładowy do rozdziału 2 - Tablice i listy. */

using System;
using System.Collections.Generic;

namespace SortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, Person> people = new SortedList<string, Person>();
            people.Add("Marcin", new Person() { Name = "Marcin", Country = CountryEnum.PL, Age = 29 });
            people.Add("Sabine", new Person() { Name = "Sabine", Country = CountryEnum.DE, Age = 25 });
            people.Add("Caroline", new Person() { Name = "Caroline", Country = CountryEnum.UK, Age = 21 });
            people.Add("John", new Person() { Name = "John", Country = CountryEnum.UK, Age = 21 });
            people.Add("Nick", new Person() { Name = "Nick", Country = CountryEnum.DE, Age = 28 });
            people.Add("Ann", new Person() { Name = "Anna", Country = CountryEnum.PL, Age = 31 });

            foreach (KeyValuePair<string, Person> person in people)
            {
                Console.WriteLine($"{person.Value.Name} (lat {person.Value.Age}) z {person.Value.Country}.");
            }
        }
    }
}
