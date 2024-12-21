using System.Diagnostics;

namespace _283._移动零
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 0, 4, 9, 0, 2 };
            MoveZeroes(nums);
            Console.WriteLine(string.Join(" ",nums));
        }

        public static void MoveZeroes(int[] nums)
        {
            int right = 0;
            int left = 0;

            while (right < nums.Length)
            {
                if (nums[right] != 0)
                {
                    if (right != left)
                    {
                        Swap(nums, right, left);
                    }
                    left++;
                }
                right++;
            }
        }

        private static void Swap(int[] nums, int index1, int index2)
        {
            int temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;
        }
    }
}
