using System;

namespace StackAndQueue
{
    class Create_Stack<T>
    {
        private Node<T> top;
        public Create_Stack()
        {
            this.top = null;
        }
        public void Push(T stackValue)
        {
            Node<T> temp = new Node<T>(stackValue);
            if (temp == null)
            {
                Console.WriteLine("Stack overflow");
            }
            temp.data = stackValue;
            temp.Next = top;
            top = temp;
        }
        public void Display()
        {
            Node<T> temp = this.top;
            if (temp == null)
            {
                Console.Write("\nStack is Empty");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List Contains: ");
                Console.ResetColor();
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.Next;
                }
            }
            Console.WriteLine("\n");
        }
        public bool IsEmpty()
        {
            return top == null;
        }
      
        public void Peek()
        {
            // check for empty stack
            if (!IsEmpty())
            {
                Console.WriteLine("\nTop element is <--{0}", top.data);
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine(top.data + "-> Popped From Stack ");
                // update the top pointer to
                // point to the next node
                top = (top).Next;
            }
        }
    }
}
