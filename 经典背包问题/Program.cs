using System;
using System.Numerics;
using System.Reflection;

internal class Program
{
    static void Main(string[] args)
    {
        //int r = RememberSearch(0, 10);
        int r = DiTui();
        Console.WriteLine(r);
    }

    private static int[] weights = new int[] { 5, 2, 4, 4, 5 };
    private static int[] values = new int[] { 4, 1, 2, 3, 4 };


    private static int Dps(int index, int residue)
    {
        if (index >= weights.Length)
        {
            return 0;
        }
        if (residue < weights[index])
        {
            return 0;
        }
        return Math.Max(values[index] + Dps(index + 1, residue - weights[index]), Dps(index + 1, residue));
    }

    static int[,] f = new int[100, 100];

    private static int RememberSearch(int index, int residue)
    {
        if (f[index, residue] > 0)
        {
            return f[index, residue];
        }
        if (index >= weights.Length)
        {
            return 0;
        }
        if (residue < weights[index])
        {
            return 0;
        }
        f[index, residue] = Math.Max(values[index] + Dps(index + 1, residue - weights[index]), Dps(index + 1, residue));
        return f[index, residue];
    }

    private static int DiTui()
    {
        for (int i = weights.Length - 1; i >= 0; i--)
        {
            for (int j = 0; j <= 10; j++)
            {
                if (j < weights[i])
                {
                    f[i, j] = f[i + 1, j];
                }
                else
                {
                    f[i, j] = Math.Max(f[i + 1, j - weights[i]] + values[i], f[i + 1, j]);
                }
            }
        }
        return f[0, 10];
    }
}
