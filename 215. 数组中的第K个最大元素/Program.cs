namespace _215._数组中的第K个最大元素
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 5, 6, 1, 4 };
            int result = FindKthLargest(nums, 2);

            Console.WriteLine(string.Join(", ", nums) + "Result=" + result);
        }


        public static int FindKthLargest(int[] nums, int k)
        {
            int index = QuickSelect(nums, 0, nums.Length - 1, k - 1);
            return nums[index];
        }


        public static int Partition(int[] nums, int left, int right)
        {
            int x = nums[right];
            int j = 0;
            for (int i = left; i <= right; i++)
            {
                if (nums[i] < x)
                {
                    Swap(nums, i, j);
                    j++;
                }
            }
            Swap(nums, j, right);
            return j;
        }


        private static int QuickSelect(int[] nums, int left, int right, int targetIndex)
        {
            if (left == right)
            {
                return left;
            }
            int index = Partition(nums, left, right);
            if (index == targetIndex)
            {
                return index;
            }
            if (targetIndex < index)
            {
                index = QuickSelect(nums, left, index - 1, targetIndex);
            }
            if (targetIndex > index)
            {
                index = QuickSelect(nums, index + 1, right, targetIndex);
            }
            return index;
        }

        private static void Swap(int[] nums, int index1, int index2)
        {
            int temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;
        }

    }
}
