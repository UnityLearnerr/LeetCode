namespace _34._在排序数组中查找元素的第一个和最后一个位置
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
            int[] result = SearchRange(nums, 7);
            Console.WriteLine(string.Join(" ", result));
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            
            int left = 0;
            int right = nums.Length - 1;
            int first = -1;
            int last = -1;

            while (left <= right) 
            {
                int mid = (left + right) / 2;

                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else if (nums[mid] > target) 
                {
                    right = mid - 1;
                }
                else // nums[mid] == target 
                {
                    first = mid;
                    right = mid - 1;
                }
            }

            left = 0;
            right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else // nums[mid] == target
                {
                    last = mid;
                    left = mid + 1;
                }
            }
            int[] result = new int[2] {first, last };
            return result;
        }


        private static int BinarySearch(int[] nums, int target, bool isLow)
        {
            int left = 0;
            int right = nums.Length - 1;
            int ans = 0;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (target < nums[mid] || (isLow && target == nums[mid]))
                {
                    right = mid - 1;
                    ans = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return ans;
        }
    }
}
