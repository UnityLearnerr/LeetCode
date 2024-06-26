/*题目描述：https://www.luogu.com.cn/problem/P1216 */

internal class Program
{
    static int n = 5;
    static int[,] a = new int[n, n];
    static void Main(string[] args)
    {
        InitData();
        int r = Ditui2();
        Console.WriteLine(r);
        Console.ReadLine();
    }

    private static void InitData()
    {
        a[0, 0] = 7;
        a[1, 0] = 3; a[1, 1] = 8;
        a[2, 0] = 8; a[2, 1] = 1; a[2, 2] = 0;
        a[3, 0] = 2; a[3, 1] = 7; a[3, 2] = 4; a[3, 3] = 4;
        a[4, 0] = 4; a[4, 1] = 5; a[4, 2] = 2; a[4, 3] = 6; a[4, 4] = 5;
        Console.WriteLine("输入完毕");
    }


    private static int DPS(int i, int j)
    {
        if (i >= n || j >= n)
        {
            return 0;
        }
        return Math.Max(DPS(i + 1, j), DPS(i + 1, j + 1)) + a[i, j];
    }

    static int[,] b = new int[n, n];
    private static int RememberSearch(int i, int j)
    {
        if (b[i, j] != 0)
        {
            return b[i, j];
        }
        if (i >= n || j >= n)
        {
            return 0;
        }
        b[i, j] = Math.Max(DPS(i + 1, j), DPS(i + 1, j + 1)) + a[i, j];
        return b[i, j];
    }

    private static int[,] f1 = new int[n + 1, n + 1];

    private static int Ditui1()
    {
        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 0; j <= i; j++)
            {
                f1[i, j] = a[i, j] + Math.Max(f1[i + 1, j], f1[i + 1, j + 1]);
            }
        }
        return f1[0, 0];
    }

    private static int[] f2 = new int[n + 1];

    private static int Ditui2()
    {
        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 0; j <= i; j++)
            {
                f2[j] = a[i, j] + Math.Max(f2[j], f2[j + 1]);
            }
        }
        return f2[0];
    }
}
