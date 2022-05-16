using System;
using StackAndQueue;


    class Program
    {
        
        static void Main(String[] args)
        {
            while (true)
            {
                Console.WriteLine("Select:\n1)Stack Using Linked List\n2)Queue using linked list\n");
                int op = Convert.ToInt16(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Create_Stack<int> stackdata = new Create_Stack<int>();
                        stackdata.Push(70);
                        stackdata.Push(30);
                        stackdata.Push(56);
                        stackdata.Display();
                        stackdata.Peek();
                        stackdata.Pop();
                        stackdata.Display();
                        stackdata.Peek();
                        stackdata.Display();
                        break;
                    case 2:
                        Create_Queue<int> queuedata = new Create_Queue<int>();
                        queuedata.Enqueue(70);
                        queuedata.Enqueue(30);
                        queuedata.Enqueue(56);
                        queuedata.Display();
                        queuedata.Dequeue();
                        queuedata.Display();
                        queuedata.Dequeue();
                        queuedata.Display();
                        queuedata.Dequeue();
                        queuedata.Display();
                        break;
                    default:
                        Console.WriteLine("Incorrect Number");
                        break;
                }
            }
        }
    }
   


