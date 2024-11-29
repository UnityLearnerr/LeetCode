namespace _1._两数之和
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int[] ret = TwoSum(nums, 9);
            Console.WriteLine(ret[0] + "  " + ret[1]);
        }


        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0, imax = nums.Length; i < imax; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {
                    return new int[2] { i, dic[target - nums[i]] };
                }
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }
            return null;
        }
    }
}
