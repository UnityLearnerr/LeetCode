using System;
using System.Collections.Generic;

namespace _115.MinStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack stack = new MinStack();
            stack.Push(-2);
            stack.Push(0);
            stack.Push(-3);
            int min1 = stack.GetMin();
            stack.Pop();
            int top = stack.Top();
            int min2 = stack.GetMin();
        }
    }

    public class MinStack
    {
        public Stack<int> m_Stack = null;
        public Stack<int> m_TempStack = null;

        /** initialize your data structure here. */
        public MinStack()
        {
            m_Stack = new Stack<int>();
            m_TempStack = new Stack<int>();
        }

        public void Push(int x)
        {
            m_Stack.Push(x);
            m_TempStack.Push(x);
        }

        public void Pop()
        {
            if (m_Stack.Count > 0)
                m_Stack.Pop();
            if (m_TempStack.Count > 0)
                m_TempStack.Pop();
        }

        public int Top()
        {
            if (m_Stack.Count > 0)
                return m_Stack.Peek();
            else
                return default(int);
        }

        public int GetMin()
        {
            if (m_TempStack.Count <= 0)
            {
                return 0;
            }
            int min = m_TempStack.Peek();
            while (m_TempStack.Count > 0)
            {
                int temp = m_TempStack.Pop();
                if (temp < min)
                {
                    min = temp;
                }
            }
            m_TempStack = m_Stack;
            return min;
        }
    }


    /// <summary>
    /// 执行用时 :1604 ms, 在所有 csharp 提交中击败了5.77%的用户
    /// 内存消耗 :52.4 MB, 在所有 csharp 提交中击败了6.06%的用户
    /// </summary>
    public class MinStackFirst
    {
        public Stack<int> m_Stack = null;

        /** initialize your data structure here. */
        public MinStackFirst()
        {
            m_Stack = new Stack<int>();
        }

        public void Push(int x)
        {
            m_Stack.Push(x);
        }

        public void Pop()
        {
            if (m_Stack.Count > 0)
                m_Stack.Pop();
        }

        public int Top()
        {
            if (m_Stack.Count > 0)
                return m_Stack.Peek();
            else
                return default(int);
        }

        public int GetMin()
        {
            if (m_Stack.Count <= 0) 
            {
                return 0;
            }
            Stack<int> tempStack = new Stack<int>();
            int min = m_Stack.Peek();
            while (m_Stack.Count > 0)
            {
                int temp = m_Stack.Pop();
                if (temp < min)
                {
                    min = temp;
                }
                tempStack.Push(temp);
            }

            while (tempStack.Count > 0) 
            {
                int temp = tempStack.Pop();
                m_Stack.Push(temp);
            }
            return min;
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */

}
