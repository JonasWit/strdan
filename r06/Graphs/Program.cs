/* Plik przykładowy do rozdziału 6 - Odkrywanie grafów. */

using System;
using System.Collections.Generic;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Krawędzie nieskierowane i nieważone
            // Graph<int> graph = new Graph<int>(false, false);

            // Node<int> n1 = graph.AddNode(1);
            // Node<int> n2 = graph.AddNode(2);
            // Node<int> n3 = graph.AddNode(3);
            // Node<int> n4 = graph.AddNode(4);
            // Node<int> n5 = graph.AddNode(5);
            // Node<int> n6 = graph.AddNode(6);
            // Node<int> n7 = graph.AddNode(7);
            // Node<int> n8 = graph.AddNode(8);

            // graph.AddEdge(n1, n2);
            // graph.AddEdge(n1, n3);
            // graph.AddEdge(n2, n4);
            // graph.AddEdge(n3, n4);
            // graph.AddEdge(n4, n5);
            // graph.AddEdge(n4, n8);
            // graph.AddEdge(n5, n6);
            // graph.AddEdge(n5, n7);
            // graph.AddEdge(n5, n8);
            // graph.AddEdge(n6, n7);
            // graph.AddEdge(n7, n8);

            // ---

            // Krawędzie nieskierowane i ważone
            // Graph<int> graph = new Graph<int>(false, true);

            // Node<int> n1 = graph.AddNode(1);
            // Node<int> n2 = graph.AddNode(2);
            // Node<int> n3 = graph.AddNode(3);
            // Node<int> n4 = graph.AddNode(4);
            // Node<int> n5 = graph.AddNode(5);
            // Node<int> n6 = graph.AddNode(6);
            // Node<int> n7 = graph.AddNode(7);
            // Node<int> n8 = graph.AddNode(8);

            // graph.AddEdge(n1, n2, 3);
            // graph.AddEdge(n1, n3, 5);
            // graph.AddEdge(n2, n4, 4);
            // graph.AddEdge(n3, n4, 12);
            // graph.AddEdge(n4, n5, 9);
            // graph.AddEdge(n4, n8, 8);
            // graph.AddEdge(n5, n6, 4);
            // graph.AddEdge(n5, n7, 5);
            // graph.AddEdge(n5, n8, 1);
            // graph.AddEdge(n6, n7, 6);
            // graph.AddEdge(n7, n8, 20);
            // graph.AddEdge(n2, n6, 20);
            // graph.AddEdge(n2, n5, 20);

            // ---

            // Krawędzie skierowane i ważone
            Graph<int> graph = new Graph<int>(true, true);

            Node<int> n1 = graph.AddNode(1);
            Node<int> n2 = graph.AddNode(2);
            Node<int> n3 = graph.AddNode(3);
            Node<int> n4 = graph.AddNode(4);
            Node<int> n5 = graph.AddNode(5);
            Node<int> n6 = graph.AddNode(6);
            Node<int> n7 = graph.AddNode(7);
            Node<int> n8 = graph.AddNode(8);

            graph.AddEdge(n1, n2, 9);
            graph.AddEdge(n1, n3, 5);
            graph.AddEdge(n2, n1, 3);
            graph.AddEdge(n2, n4, 18);
            graph.AddEdge(n3, n4, 12);
            graph.AddEdge(n4, n2, 2);
            graph.AddEdge(n4, n8, 8);
            graph.AddEdge(n5, n4, 9);
            graph.AddEdge(n5, n6, 2);
            graph.AddEdge(n5, n7, 5);
            graph.AddEdge(n5, n8, 3);
            graph.AddEdge(n6, n7, 1);
            graph.AddEdge(n7, n5, 4);
            graph.AddEdge(n7, n8, 6);
            graph.AddEdge(n8, n5, 3);

            Console.WriteLine("Minimalne drzewo rozpinające - algorytm Kruskala:");
            List<Edge<int>> mstKruskal = graph.MinimumSpanningTreeKruskal();
            mstKruskal.ForEach(e => Console.WriteLine(e));

            Console.WriteLine("\nMinimalne drzewo rozpinające - algorytm Prima:");
            List<Edge<int>> mstPrim = graph.MinimumSpanningTreePrim();
            mstPrim.ForEach(e => Console.WriteLine(e));

            Console.WriteLine("\nNajkrótsza ścieżka - algorytm Dijkstry:");
            List<Edge<int>> path = graph.GetShortestPathDijkstra(n1, n5);
            path.ForEach(e => Console.WriteLine(e));

            Console.WriteLine("\nKolorowanie grafu:");
            int[] colors = graph.Color();
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"Węzeł {graph.Nodes[i].Data}: {colors[i]}");
            }

            Console.WriteLine("\nPrzeszukiwanie w głąb:");
            List<Node<int>> dfsNodes = graph.DFS();
            dfsNodes.ForEach(n => Console.WriteLine(n));

            Console.WriteLine("\nPrzeszukiwanie wszerz:");
            List<Node<int>> bfsNodes = graph.BFS();
            bfsNodes.ForEach(n => Console.WriteLine(n));
        }
    }
}
