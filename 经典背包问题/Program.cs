using System;
using System.Numerics;

internal class Program
{
    static void Main(string[] args)
    {
        int r = Dps(0, 10);
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
}
