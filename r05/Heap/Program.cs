/* Plik przykładowy do rozdziału 5 - Warianty drzew. */

using DIBRIS.Hippie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsorted = new List<int>() { 50, 33, 78, -23, 90, 41 };
            MultiHeap<int> heap = HeapFactory.NewBinaryHeap<int>();
            unsorted.ForEach(i => heap.Add(i));
            Console.WriteLine("Nieposortowane: " + string.Join(", ", unsorted));

            List<int> sorted = new List<int>(heap.Count);
            while (heap.Count > 0)
            {
                sorted.Add(heap.RemoveMin());
            }
            Console.WriteLine("Posortowane: " + string.Join(", ", sorted));
        }
    }
}
