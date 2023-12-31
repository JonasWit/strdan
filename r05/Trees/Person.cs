﻿/* Plik przykładowy do rozdziału 5 - Warianty drzew. */

using System;

namespace Trees
{
    public class Person : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public Person() { }

        public Person(int id, string name, string role)
        {
            Id = id;
            Name = name;
            Role = role;
        }

        public int CompareTo(object obj)
        {
            return Id.CompareTo((int)obj);
        }
    }
}