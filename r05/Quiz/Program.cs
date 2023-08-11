/* Plik przykładowy do rozdziału 5 - Warianty drzew. */

using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<QuizItem> tree = GetTree();
            BinaryTreeNode<QuizItem> node = tree.Root;
            while (node != null)
            {
                if (node.Left != null || node.Right != null)
                {
                    Console.Write(node.Data.Text);
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.T:
                            WriteAnswer(" Tak");
                            node = node.Left;
                            break;
                        case ConsoleKey.N:
                            WriteAnswer(" Nie");
                            node = node.Right;
                            break;
                    }
                }
                else
                {
                    WriteAnswer(node.Data.Text);
                    node = null;
                }
            }
        }

        private static BinaryTree<QuizItem> GetTree()
        {
            BinaryTree<QuizItem> tree = new BinaryTree<QuizItem>();
            tree.Root = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Czy masz doświadczenie w programowaniu aplikacji?"),
                Children = new List<TreeNode<QuizItem>>()
                {
                    new BinaryTreeNode<QuizItem>()
                    {
                        Data = new QuizItem("Czy pracowałeś jako programista przez ponad 5 lat?"),
                        Children = new List<TreeNode<QuizItem>>()
                        {
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data = new QuizItem("Aplikuj na stanowisko starszego programisty!")
                            },
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data = new QuizItem("Aplikuj na stanowisko programisty!")
                            }
                        }
                    },
                    new BinaryTreeNode<QuizItem>()
                    {
                        Data = new QuizItem("Czy skończyłeś studia?"),
                        Children = new List<TreeNode<QuizItem>>()
                        {
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data = new QuizItem("Aplikuj na stanowisko młodszego programisty!")
                            },
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data = new QuizItem("Czy w ciągu semestru znajdziesz trochę czasu?"),
                                Children = new List<TreeNode<QuizItem>>()
                                {
                                    new BinaryTreeNode<QuizItem>()
                                    {
                                        Data = new QuizItem("Aplikuj do naszego programu praktyk długoterminowych!")
                                    },
                                    new BinaryTreeNode<QuizItem>()
                                    {
                                        Data = new QuizItem("Aplikuj do programu praktyk wakacyjnych!")
                                    }
                                }
                            }
                        }
                    }
                }
            };
            tree.Count = 9;
            return tree;
        }


        private static void WriteAnswer(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
