namespace _509._斐波那契数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Fib1(4);
            Console.WriteLine(result);
        }


        public static int Fib(int n)
        {
            int f0 = 0;
            int f1 = 1;
            if (n == 0)
            {
                return f0;
            }
            if (n == 1)
            {
                return f1;
            }
            int f = 0;
            for (int i = 2; i <= n; i++)
            {
                f = f0 + f1;
                f0 = f1;
                f1 = f;
            }
            return f;
        }

        public static int Fib1(int n) 
        {
            if (n == 0) 
            {
                return 0;
            }
            if (n == 1) 
            {
                return 1;
            }
            return Fib1(n - 1) + Fib1(n - 2);
        }
    }
}
