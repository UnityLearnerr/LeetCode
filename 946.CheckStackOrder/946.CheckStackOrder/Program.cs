using System;
using System.Collections.Generic;

namespace _946.CheckStackOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            bool result = s.ValidateStackSequences(new int[] { 1, 2, 3, 0 }, new int[] { 2, 1, 3, 0 });
            Console.WriteLine(result);
        }
    }
    public class Solution
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            Stack<int> stack = new Stack<int>();
            int popIndex = 0;
            int pushIndex = 0;

            while (pushIndex < pushed.Length)
            {
                if (stack.Count > 0 && stack.Peek() == popped[popIndex])
                {
                    popIndex++;
                    stack.Pop();
                    continue;
                }
                if (pushed[pushIndex] == popped[popIndex])
                {
                    popIndex++;
                }
                else 
                {
                    stack.Push(pushed[pushIndex]);
                }
                
                pushIndex++;
            }

            while (stack.Count > 0)
            {
                if (stack.Pop() == popped[popIndex])
                {
                    popIndex++;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
