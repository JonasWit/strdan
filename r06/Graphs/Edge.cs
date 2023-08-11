/* Plik przykładowy do rozdziału 6 - Odkrywanie grafów. */

namespace Graphs
{
    public class Edge<T>
    {
        public Node<T> From { get; set; }
        public Node<T> To { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"Krawędź: {From.Data} -> {To.Data}, waga: {Weight}";
        }
    }
}
