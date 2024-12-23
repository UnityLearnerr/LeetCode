namespace _287._寻找重复数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 4, 2, 2, 2, 2 };
            int result =  FindDuplicate(nums);
            Console.WriteLine(result);
        }


        public static int FindDuplicate(int[] nums)
        {
            int left = 1;
            int right = nums.Length - 1;
            int result = 0;

            while (left <= right) 
            {
                int mid = (left + right) / 2;
                int count = 0;
                for (int i = 0; i < nums.Length; i++) 
                {
                    if (nums[i] <= mid) 
                    {
                        count++;
                    }
                }
                if (count <= mid)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                    result = mid;
                }
            }
            return result;
        }
    }
}
