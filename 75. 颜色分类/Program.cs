namespace _75._颜色分类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 0, 2, 1, 1, 0 };
            SortColors(nums);
            Console.WriteLine(string.Join(" ", nums));
            Console.Read();
        }

        /// <summary>
        /// 双指针
        /// </summary>
        /// <param name="nums"></param>
        private static void SortColors(int[] nums)
        {
            int zero = 0;
            int two = nums.Length - 1;
            int i = 0;
            while (i <= two)
            {
                if (nums[i] == 0)
                {
                    Swap(nums, i, zero);
                    i++;
                    zero++;
                }
                else if (nums[i] == 1)
                {
                    i++;
                }
                else  // nums[i] == 2
                {
                    Swap(nums, i, two);
                    two--;
                }

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
