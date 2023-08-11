/* Plik przykładowy do rozdziału 6 - Odkrywanie grafów. */

namespace Graphs
{
    public class Subset<T>
    {
        public Node<T> Parent { get; set; }
        public int Rank { get; set; }

        public override string ToString()
        {
            return $"Podzbiór o randze {Rank}, rodzic: {Parent.Data} (indeks: {Parent.Index})";
        }
    }
}
