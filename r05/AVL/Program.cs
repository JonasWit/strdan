/* Plik przykładowy do rozdziału 5 - Warianty drzew. */

using System;
using System.Collections.Generic;
using System.DataStructures;
using System.Text;
using System.Threading.Tasks;

namespace AVL
{
    class Program
    {
        static void Main(string[] args)
        {
            AvlTree<int> tree = new AvlTree<int>();
            for (int i = 1; i < 10; i++)
            {
                tree.Add(i);
            }

            Console.WriteLine("Poprzecznie: " + string.Join(", ", tree.GetInorderEnumerator()));
            Console.WriteLine("Wstecznie: " + string.Join(", ", tree.GetPostorderEnumerator()));
            Console.WriteLine("Wszerz: " + string.Join(", ", tree.GetBreadthFirstEnumerator()));

            AvlTreeNode<int> node = tree.FindNode(8);
            Console.WriteLine($"Dzieci węzła {node.Value} (wysokość = {node.Height}): {node.Left.Value} i {node.Right.Value}.");
        }
    }
}
