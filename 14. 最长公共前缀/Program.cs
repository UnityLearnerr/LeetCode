using System.Text;

namespace _14._最长公共前缀
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[] { "a" };
            string result = LongestCommonPrefix(strs);
            Console.WriteLine(result);
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length <= 0 || strs[0].Length <= 0) 
            {
                return "";
            }
            int index = 0;
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                bool isBreak = false;
                if (index >= strs[0].Length)
                {
                    break;
                }
                char c = strs[0][index];
                for (int i = 1, imax = strs.Length; i < imax; i++)
                {
                    if (index >= strs[i].Length || c != strs[i][index])
                    {
                        isBreak = true;
                        break;
                    }
                }
                if (isBreak)
                {
                    break;
                }
                sb.Append(c);
                index++;
            }

            return sb.ToString();
        }
    }
}
