namespace _55._跳跃游戏
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0 };
            bool isCanJump = CanJump(nums);
            Console.WriteLine(isCanJump);
        }

        public static bool CanJump(int[] nums)
        {
            int maxReach = 0;
            for (int i = 0, imax = nums.Length; i < imax; i++)
            {
                maxReach = Math.Max(i + nums[i], maxReach);
                if (maxReach >= nums.Length - 1)
                {
                    return true;
                }
                if (i >= maxReach) 
                {
                    return false;
                }
            }
            return false;
        }

    }
}
