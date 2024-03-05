using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 6, 8, 7, 9, 3, 5, 1, 4, 2 };
            InsertSort(list1);
            PrintList(list1);
            Console.ReadLine();
        }

        /// <summary>
        /// 冒泡排序
        /// 将最大的数冒到最后的位置
        /// </summary>
        /// <param name="arr"></param>
        private static void BubbleSort(List<int> arr)
        {
            if (arr.Count < 2)
            {
                return;
            }
            for (int i = 1, imax = arr.Count; i < imax; i++)
            {
                for (int j = 0, jmax = arr.Count - i; j < jmax; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
        }

        /// <summary>
        /// 选择排序
        /// 从左到右遍历,选择最小的数
        /// </summary>
        /// <param name="arr"></param>
        private static void SelectionSort(List<int> arr)
        {
            if (arr.Count < 2)
            {
                return;
            }
            for (int i = 0, imax = arr.Count - 1; i < imax; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Swap(arr, i, j);
                    }
                }
            }
        }

        /// <summary>
        /// 插入排序
        /// 将元素插入到正确的位置保证0i之间有序
        /// 不稳定排序
        /// 如果元素大->小,时间复杂度为n^2
        /// 如果元素小->大,时间复杂度为n
        /// </summary>
        /// <param name="arr"></param>
        private static void InsertSort(List<int> arr)
        {
            if (arr.Count < 2)
            {
                return;
            }
            for (int i = 1, imax = arr.Count; i < imax; i++)
            {
                for (int j = i - 1; j >= 0 && arr[j] > arr[j + 1]; j--)
                {
                    Swap(arr, j, j + 1);
                }
            }
        }

        private static void Swap(List<int> arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        private static void PrintList(List<int> list)
        {
            string s = "";
            for (int i = 0, imax = list.Count; i < imax; i++)
            {
                s += list[i] + ",";
            }
            Console.WriteLine(s);
        }
    }
}
