internal class Program
{
    static void Main(string[] args)
    {
        int ret = ClimbStairs(5);
        Console.WriteLine(ret);
        Console.ReadLine();
    }


    /// <summary>
    /// 暴力递归方式，时间复杂度是2^n
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    //public static int ClimbStairs(int n)
    //{
    //    if (n == 1) return 1;
    //    if (n == 2) return 2;
    //    return ClimbStairs(n - 1) + ClimbStairs(n - 2);
    //}

    static int[] cache = new int[46];
    /// <summary>
    /// 记录重复的计算 时间复杂度n 空间复杂度n
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    //public static int ClimbStairs(int n) 
    //{
    //    if (cache[n] != 0) return cache[n];
    //    if (n == 1) return 1;
    //    if (n == 2) return 2;
    //    int sum = ClimbStairs(n - 1) + ClimbStairs(n - 2);
    //    cache[n] = sum;
    //    return sum;
    //}


    public static int ClimbStairs(int n) 
    {
        int n1 = 1;
        int n2 = 2;
        if (n == 1)
        {
            return n1;
        }
        if (n == 2) 
        {
            return n2;
        }
        int temp;
        for (int i = 3; i <= n; i++)
        {
            temp = n2;
            n2 += n1;
            n1 = temp;
        }
        return n2;
    }
}
/*
 * 将父问题分解为多个子问题，这里5阶的结果为4阶和3阶结果之和，原因是3阶走2阶到5阶，4阶走1阶到5阶。
 * 方法1.暴力递归，时间复杂度高
 * 方法2.将中间结果记录下来，防止重复递归计算
 * 方法3.画出递归数，从低网上计算出递推公式进行求解
 */