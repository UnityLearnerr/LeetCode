namespace _189._轮转数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            Rotate2(nums, 2);
            for (int i = 0, imax = nums.Length; i < imax; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        /// <summary>
        /// 环形替换
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static void Rotate2(int[] nums, int k)
        {
            int curMove = nums[0];
            int index = 0;
            for (int i = 0, imax = nums.Length; i < imax; i++)
            {
                index = (index + k) % nums.Length;
                int temp = nums[index];
                nums[index] = curMove;
                curMove = temp;
            }
        }

        public static void Rotate1(int[] nums, int k)
        {
            int[] tempNums = new int[nums.Length];

            for (int i = 0, imax = tempNums.Length; i < imax; i++)
            {
                int destIndex = (i + k) % tempNums.Length;
                tempNums[destIndex] = nums[i];
            }

            for (int i = 0, imax = tempNums.Length; i < imax; i++)
            {
                nums[i] = tempNums[i];
            }
        }


        public static void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        private static void Reverse(int[] nums, int start, int end)
        {
            if (start < 0 || end >= nums.Length || start >= end)
            {
                return;
            }
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
