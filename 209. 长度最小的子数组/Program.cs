namespace _209._长度最小的子数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 3, 1, 2, 4, 3 };
            int result =  MinSubArrayLen(7, nums);
            Console.WriteLine(result);
        }

        public static int MinSubArrayLen(int target, int[] nums)
        {
            int start = 0;
            int end = 0;
            int sum = 0;
            int result = int.MaxValue;

            while (end < nums.Length)
            {
                sum += nums[end];
                while (sum >= target)
                {
                    result = Math.Min(end - start + 1, result);
                    sum -= nums[start];
                    start++;
                }
                end++;
            }
            return result <= nums.Length ? result : 0;
        }
    }
}
