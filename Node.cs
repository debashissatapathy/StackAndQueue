using System;

namespace StackAndQueue
{
    class Node<T>
    {
        public T data;
        public Node<T> Next;
        public Node(T value)
        {
            this.data = value;
        }

    }
}
