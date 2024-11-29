namespace _739._每日温度
{
    internal class Program
    {
        // 单调栈
        static void Main(string[] args)
        {
            int[] temperatures = new int[] { 89, 62, 70, 58, 47, 47, 46, 76, 100, 70 };
            int[] ans = DailyTemperatures(temperatures);
            for (int i = 0; i < ans.Length; i++)
            {
                Console.WriteLine(ans[i]);
            }
        }

        public static int[] DailyTemperatures(int[] temperatures)
        {
            Stack<int> indexStack = new Stack<int>();
            int[] ans = new int[temperatures.Length];
            for (int i = 0, imax = ans.Length; i < imax; i++)
            {
                while (indexStack.Count > 0 && temperatures[i] > temperatures[indexStack.Peek()])
                {
                    int index = indexStack.Pop();
                    ans[index] = i - index;
                }
                indexStack.Push(i);
            }
            return ans;
        }
    }
}
