using System;
using System.Collections;
using System.Collections.Generic;

namespace StackRealision
{
    class Program
    {
        static void Main(string[] args)
        {
            StackRealizeQueue<string> stack = new StackRealizeQueue<string>();
            Console.WriteLine("1stack.Pop()   " + stack.Pop());

            stack.Push("a");
            Console.WriteLine("2stack.peek()   " + stack.Peek());
            stack.Push("b");
            Console.WriteLine("3stack.peek()   " + stack.Pop());
            stack.Push("c");
            while (stack.Count > 0)
            {
                Console.WriteLine("4stack.Pop()   " + stack.Pop());
            }
        }
    }

    public class StackRealizeQueue<T>
    {
        private Queue<T> m_Queue = null;

        public int Count
        {
            get
            {
                return m_Queue.Count;
            }
        }

        public StackRealizeQueue()
        {
            m_Queue = new Queue<T>();
        }

        public void Push(T obj)
        {
            Queue<T> tempQueue = new Queue<T>();
            tempQueue.Enqueue(obj);

            while (m_Queue.Count > 0)
            {
                T temp = m_Queue.Dequeue();
                tempQueue.Enqueue(temp);
            }
            m_Queue = tempQueue;
        }


        public T Pop()
        {
            if (m_Queue.Count == 0)
                return default(T);
            else
                return m_Queue.Dequeue();
        }

        public T Peek()
        {
            if (m_Queue.Count == 0)
                return default(T);
            else
                return m_Queue.Peek();
        }

        public void Clear()
        {
            m_Queue.Clear();
        }

    }
}
