namespace _53._最大子数组和
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int result = MaxSubArray(nums);
            Console.WriteLine(result);
        }

        public static int MaxSubArray(int[] nums)
        {
            int preSum = 0;
            int result = nums[0];

            for (int i = 0, imax = nums.Length; i < imax; i++)
            {
                preSum = Math.Max(preSum + nums[i], nums[i]);
                result = Math.Max(result, preSum);
            }
            return result;
        }
    }
}
