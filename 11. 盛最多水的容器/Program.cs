namespace _11._盛最多水的容器
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int result = MaxArea(height);
            Console.WriteLine(result);
        }

        public static int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int value = 0;
            while (left < right)
            {
                int w = right - left;
                int h = Math.Min(height[right], height[left]);
                value = Math.Max(value, w * h);
                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return value;
        }

    }
}
