using System.Linq;

namespace _3._无重复字符的最长子串
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "abcabcbb";
            int result =  LengthOfLongestSubstring(str);
            Console.WriteLine(result);
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int start = 0;
            int end = 0;
            int result = 0;
            HashSet<char> record = new HashSet<char>();
            while (end < s.Length)
            {
                while (record.Contains(s[end])) 
                {
                    record.Remove(s[start]);
                    start++;
                }
                result = Math.Max(end - start + 1, result);
                record.Add(s[end]);
                end++;
            }
            return result;
        }
    }
}
