namespace _136._只出现一次的数字
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { };
            Console.WriteLine("Hello, World!");
        }

        public int SingleNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0,imax = nums.Length; i < imax; i++) 
            {
                result ^= nums[i];
            }
            return result;
        }
    }
}
