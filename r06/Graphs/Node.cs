/* Plik przykładowy do rozdziału 6 - Odkrywanie grafów. */

using System.Collections.Generic;

namespace Graphs
{
    public class Node<T>
    {
        public int Index { get; set; }
        public T Data { get; set; }
        public List<Node<T>> Neighbors { get; set; } = new List<Node<T>>();
        public List<int> Weights { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"Węzeł o indeksie {Index}: {Data}, liczba sąsiadów: {Neighbors.Count}";
        }
    }
}
