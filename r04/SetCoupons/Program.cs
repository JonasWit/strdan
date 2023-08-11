/* Plik przykładowy do rozdziału 4 - Słowniki i zbiory. */

using System;
using System.Collections.Generic;

namespace SetCoupons
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> usedCoupons = new HashSet<int>();
            do
            {
                Console.Write("Wprowadź numer kuponu: ");
                string couponString = Console.ReadLine();
                if (int.TryParse(couponString, out int coupon))
                {
                    if (usedCoupons.Contains(coupon))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ten kupon został już wykorzystany :-(");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        usedCoupons.Add(coupon);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Dzięki! :-)");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                else
                {
                    break;
                }
            }
            while (true);

            Console.WriteLine();
            Console.WriteLine("Lista wykorzystanych kuponów:");
            foreach (int coupon in usedCoupons)
            {
                Console.WriteLine(coupon);
            }
        }
    }
}
