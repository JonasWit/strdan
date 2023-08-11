/* Plik przykładowy do rozdziału 2 - Tablice i listy. */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SimpleLists01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>();
            do
            {
                Console.Write("Wprowadź liczbę: ");
                string numberString = Console.ReadLine();
                if (!double.TryParse(numberString, NumberStyles.Float, new NumberFormatInfo(), out double number))
                {
                    break;
                }

                numbers.Add(number);
                Console.WriteLine($"Średnia wartość: {numbers.Average()}");
            }
            while (true);
        }
    }
}
