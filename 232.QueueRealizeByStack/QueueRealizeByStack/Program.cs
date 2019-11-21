using System;
using System.Collections.Generic;

namespace QueueRealizeByStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();
            queue.Push(1);
            queue.Push(2);
            Console.WriteLine(queue.Peek());
        }
    }

    public class MyQueue
    {
        public Stack<int> m_Stack = null;
        /** Initialize your data structure here. */
        public MyQueue()
        {
            m_Stack = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            m_Stack.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            Stack<int> tempStack = new Stack<int>();
            while (m_Stack.Count > 0) 
            {
                int temp = m_Stack.Pop();
                tempStack.Push(temp);
            }
            int result = tempStack.Pop();
            while (tempStack.Count > 0) 
            {
                int temp = tempStack.Pop();
                m_Stack.Push(temp);
            }
            return result;
        }

        /** Get the front element. */
        public int Peek()
        {
            Stack<int> tempStack = new Stack<int>();
            while (m_Stack.Count > 0)
            {
                int temp = m_Stack.Pop();
                tempStack.Push(temp);
            }
            int result = tempStack.Peek();
            while (tempStack.Count > 0)
            {
                int temp = tempStack.Pop();
                m_Stack.Push(temp);
            }
            return result;
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return m_Stack.Count <= 0;
        }
    }
}
