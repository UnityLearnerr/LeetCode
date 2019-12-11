using System;
using System.Collections.Generic;

namespace _224.SampleCaculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int result = s.Calculate("(7)-(0)+(4)");
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int Calculate(string s)
        {
            List<string> parseStr = Parse(s);
            int num = CalculateNum(parseStr);
            return num;
        }


        private int CalculateNum(List<string> parseStr)
        {
            Stack<string> numStack = new Stack<string>();
            Stack<string> opStack = new Stack<string>();
            bool isCaculate = false;

            for (int i = 0, imax = parseStr.Count; i < imax; i++)
            {
                if (CheckIsBracket(parseStr[i]) == EBracketType.Left)
                {
                    isCaculate = false;
                }
                else if (CheckIsBracket(parseStr[i]) == EBracketType.Right)
                {
                    if (numStack.Count > 1 && opStack.Count > 0) 
                    {
                        int num2 = int.Parse(numStack.Pop());
                        int num1 = int.Parse(numStack.Pop());
                        string op = opStack.Pop();
                        if (op == "+")
                        {
                            numStack.Push((num1 + num2).ToString());
                        }
                        else if (op == "-")
                        {
                            numStack.Push((num1 - num2).ToString());
                        }
                    }
                }
                else if (CheckIsOperator(parseStr[i]) != EOperatorType.None)
                {
                    isCaculate = true;
                    opStack.Push(parseStr[i]);
                }
                else // 数字
                {
                    if (isCaculate && numStack.Count > 0)
                    {
                        int num1 = int.Parse(numStack.Pop());
                        int num2 = int.Parse(parseStr[i]);
                        string op = opStack.Pop();
                        if (op == "+")
                        {
                            numStack.Push((num1 + num2).ToString());
                        }
                        else if (op == "-")
                        {
                            numStack.Push((num1 - num2).ToString());
                        }
                    }
                    else
                    {
                        numStack.Push(parseStr[i]);
                    }
                }
            }

            while (opStack.Count > 0)
            {

                int num2 = int.Parse(numStack.Pop());
                int num1 = int.Parse(numStack.Pop());
                string op = opStack.Pop();
                if (op == "-")
                {
                    numStack.Push((num1 - num2).ToString());
                }
                else if (op == "+")
                {
                    numStack.Push((num1 + num2).ToString());
                }
            }
            return int.Parse(numStack.Pop());
        }

        private List<string> Parse(string s)
        {
            List<string> list = new List<string>();
            for (int i = 0, imax = s.Length; i < imax; i++)
            {
                if (CheckIsEmpty(s[i]))
                {
                    continue;
                }

                if (CheckIsNum(s[i]))
                {
                    if (list.Count > 0 && int.TryParse(list[list.Count - 1], out int tempNum))
                        list[list.Count - 1] = list[list.Count - 1] + s[i].ToString();
                    else
                        list.Add(s[i].ToString());
                }

                if (CheckIsBracket(s[i].ToString()) != EBracketType.None)
                {
                    list.Add(s[i].ToString());
                }
                else if (CheckIsOperator(s[i].ToString()) != EOperatorType.None)
                {
                    list.Add(s[i].ToString());
                }
            }
            return list;
        }


        private bool CheckIsNum(char c)
        {
            if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private EBracketType CheckIsBracket(string c)
        {
            if (c == "(")
            {
                return EBracketType.Left;
            }
            else if (c == ")")
            {
                return EBracketType.Right;
            }
            else
            {
                return EBracketType.None;
            }
        }

        private EOperatorType CheckIsOperator(string c)
        {
            if (c == "+")
            {
                return EOperatorType.Plus;
            }
            else if (c == "-")
            {
                return EOperatorType.Sub;
            }
            else
            {
                return EOperatorType.None;
            }
        }

        private bool CheckIsEmpty(char c)
        {
            return c == ' ';
        }

        enum EOperatorType
        {
            None = 0,
            Plus = 1,
            Sub = 2,
        }

        enum EBracketType
        {
            None = 0,
            Right = 1,
            Left = 2,
        }
    }
}
