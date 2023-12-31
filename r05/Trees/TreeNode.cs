﻿/* Plik przykładowy do rozdziału 5 - Warianty drzew. */

using System.Collections.Generic;

namespace Trees
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public List<TreeNode<T>> Children { get; set; }
    }
}
