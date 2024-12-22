using System.ComponentModel;

namespace _48._旋转图像
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][] { [5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16] };
            Rotate(matrix);
            for (int i = 0, imax = matrix[0].Length; i < imax; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }

        public static void Rotate(int[][] matrix)
        {
            // 沿着左上到右下对角线对称过来
            for (int i = 0, imax = matrix.Length; i < imax; i++)
            {
                for (int j = i, jmax = matrix.Length; j < jmax; j++)
                {
                    Swap(matrix, i, j, j, i);
                }
            }

            // 沿着中间竖线对称过来
            for (int i = 0, imax = matrix.Length; i < imax; i++)
            {
                for (int j = 0, jmax = matrix.Length / 2; j < jmax; j++)
                {
                    Swap(matrix, i, j, i, matrix.Length - j - 1);
                }
            }
        }

        private static void Swap(int[][] matrix, int i1, int j1, int i2, int j2)
        {
            int temp = matrix[i1][j1];
            matrix[i1][j1] = matrix[i2][j2];
            matrix[i2][j2] = temp;
        }
    }
}
