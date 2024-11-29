namespace _20._有效的括号
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "()[]{}[";
            bool result = IsValid(s);
            Console.WriteLine(result);
        }

        public static bool IsValid(string s)
        {
            Stack<char> chars = new Stack<char>();
            for (int i = 0, imax = s.Length; i < imax; i++)
            {
                chars.TryPeek(out char top);
                if (top == '(' && s[i] == ')' || top == '[' && s[i] == ']' || top == '{' && s[i] == '}')
                {
                    chars.Pop();
                }
                else 
                {
                    chars.Push(s[i]);
                }
            }
            return chars.Count == 0;
        }
    }
}
