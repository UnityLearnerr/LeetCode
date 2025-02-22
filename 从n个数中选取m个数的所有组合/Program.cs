namespace 从n个数中选取m个数的所有组合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = new List<List<int>>();
            var numbers = new int[] { 1, 2, 3, 4,5 };
            Backtrack(numbers, 3, 0, new List<int>(), result);
            foreach (var combo in result)
            {
                Console.WriteLine(string.Join(", ", combo));
            }
        }


        private static void Backtrack<T>(T[] array, int m, int start, List<T> current, List<List<T>> result)
        {
            if (current.Count == m)
            {
                result.Add(new List<T>(current));
                return;
            }

            for (int i = start; i < array.Length; i++)
            {
                current.Add(array[i]);
                Backtrack(array, m, i + 1, current, result); // 关键点：i+1避免重复选取 
                current.RemoveAt(current.Count - 1); // 回溯 
            }
        }
    }
}
