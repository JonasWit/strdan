/* Plik przykładowy do rozdziału 2 - Tablice i listy. */

using System.Collections;
using System.Collections.Generic;

namespace CircularLinkedList
{
    public class CircularLinkedList<T> : LinkedList<T>
    {
        public new IEnumerator GetEnumerator()
        {
            return new CircularLinkedListEnumerator<T>(this);
        }
    }
}
