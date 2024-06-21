using System;
using System.Collections.Generic;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 8,7,6,5,4,3,2,1 };
            int[] list2 = new int[list1.Count];
            //InsertSort(list1);
            //MergeSort(list1, 0, list1.Count - 1, list2);
            //HeapSort(list1);
            int stack = 0;
            QuickSort(list1, 0, list1.Count -1,ref stack);
            Console.WriteLine(stack);
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

        #region 归并排序
        private static void MergeSort(List<int> list, int left, int right, int[] tempList)
        {
            if (left >= right)
            {
                return;
            }
            int mid = (left + right) / 2;
            MergeSort(list, left, mid, tempList);
            MergeSort(list, mid + 1, right, tempList);
            Merge(list, left, mid, right, tempList);
        }

        private static void Merge(List<int> list, int left, int mid, int right, int[] tempList)
        {
            int i = left;
            int j = mid + 1;
            int t = 0;
            while (i <= mid && j <= right)
            {
                if (list[i] < list[j])
                {
                    tempList[t] = list[i];
                    i++;
                }
                else
                {
                    tempList[t] = list[j];
                    j++;
                }
                t++;
            }
            while (i <= mid)
            {
                tempList[t++] = list[i++];
            }
            while (j <= right)
            {
                tempList[t++] = list[j++];
            }
            t = 0;
            while (left <= right)
            {
                list[left++] = tempList[t++];
            }
        }
        #endregion

        #region 堆排序
        private static void HeapSort(List<int> list)
        {
            for (int i = (list.Count - 1) / 2; i >= 0; i--)
            {
                int swapIndex = i;
                while (BigHeap(list, list.Count, swapIndex, 2 * swapIndex + 1, 2 * swapIndex + 2, out swapIndex)) ;
            }

            for (int i = 1; i <= list.Count; i++)
            {
                Swap(list, 0, list.Count - i);
                int swapIndex = 0;
                while (BigHeap(list, list.Count - i, swapIndex, 2 * swapIndex + 1, 2 * swapIndex + 2, out swapIndex)) ;
            }
        }

        private static bool BigHeap(List<int> list, int heapCount, int f, int c1, int c2, out int swapIndex)
        {
            swapIndex = f;
            if (c1 < heapCount && list[c1] > list[swapIndex])
            {
                swapIndex = c1;
            }
            if (c2 < heapCount && list[c2] > list[swapIndex])
            {
                swapIndex = c2;
            }
            if (swapIndex != f)
            {
                Swap(list, f, swapIndex);
                return true;
            }
            return false;
        }

        #endregion

        #region 快速排序

        public static void QuickSort(List<int> list, int l, int r, ref int stack)
        {
            stack++;
            if (l < r)
            {
                int i = l;
                int j = r;
                int x = list[i];
                while (i < j)
                {
                    while (i < j && list[j] >= x)
                    {
                        j--;
                    }
                    if (list[j] < x)
                    {
                        list[i] = list[j];
                    }
                    while (i < j && list[i] < x)
                    {
                        i++;
                    }
                    if (list[i] > x) 
                    {
                        list[j] = list[i];
                    }
                }
                list[i] = x;
                QuickSort(list, l, i,ref stack);
                QuickSort(list, i + 1, r, ref stack);
            }
        }
        #endregion


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
