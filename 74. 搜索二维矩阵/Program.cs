namespace _74._搜索二维矩阵
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = { [1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60] };
            bool result = SearchMatrix(matrix, 0);
            Console.WriteLine(result);
        }

        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int i = 0;
            int left = 0, right = matrix.Length - 1;
            while (left <= right) 
            {
                int mid = (left + right) / 2;
                if (target >= matrix[mid][0])
                { 
                    left = mid + 1;
                    i = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }

            int[] row = matrix[i];
            left = 0;
            right = row.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (target > row[mid])
                {
                    left = mid + 1;
                }
                else if (target < row[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
