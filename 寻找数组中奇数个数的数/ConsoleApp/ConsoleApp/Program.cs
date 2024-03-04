using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{


    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            Test2();
        }

        private static void Test1()
        {
            int[] arr = new int[] { 2, 2, 2, 2, 6, 6, 6, 8, 8, 8, 8 };
            int result = FindOnlyOneOddCountItem(arr);
            if (result > 0)
            {
                Console.WriteLine($"找到数量为奇数的元素={result}");
            }
            else
            {
                Console.WriteLine("未找到数量为奇数的元素");
            }
            Console.ReadLine();
        }


        //题目说明
        //一个数组中，只存在唯一数量为奇数的数，找到这个数
        //例如一个数组[2,2,2,2,6,6,6,8,8,8,8], 结果为6
        private static int FindOnlyOneOddCountItem(int[] arr)
        {
            int xor = 0;
            for (int i = 0, imax = arr.Length; i < imax; i++)
            {
                xor ^= arr[i];
            }
            return xor;
        }


        private static void Test2()
        {
            int[] arr = new int[] { 1, 1, 1, 2, 2, 3, 3, 3, 4, 4 };
            FindOnlyTwoOddCountItem(arr);
            Console.ReadLine();
        }

        //题目说明
        //一个数组中，只存在唯二数量为奇数的数，找到这个数
        //例如一个数组[2,2,2,2,6,6,6,8,8,8,8], 结果为6
        private static int FindOnlyTwoOddCountItem(int[] arr)
        {
            int xor = 0;
            for (int i = 0, imax = arr.Length; i < imax; i++)
            {
                xor ^= arr[i];
            }
            if (xor == 0)
            {
                Console.WriteLine("不存在");
            }
            int sign = (~xor + 1) & xor;
            int a = 0;
            for (int i = 0, imax = arr.Length; i < imax; i++)
            {
                if ((arr[i] & sign) == 0)
                {
                    continue;
                }
                a ^= arr[i];
            }
            int b = xor ^ a;
            Console.WriteLine($"{a}==={b}");
            return sign;
        }

    }
}
