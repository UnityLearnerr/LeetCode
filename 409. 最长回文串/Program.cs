namespace _409._最长回文串
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = LongestPalindrome1("bananas");
            Console.WriteLine(num);
        }

        public static int LongestPalindrome1(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int palindromeLenghth = 0;
            for (int i = 0, imax = s.Length; i < imax; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], 0);
                }
                dic[s[i]] += 1;
            }

            foreach (int count in dic.Values)
            {
                if ((count & 1) == 1) // 字母为单数
                {
                    if ((palindromeLenghth & 1) == 0) // 当前回文长度为偶数
                    {
                        palindromeLenghth += count;
                    }
                    else // 回文长度为奇数
                    {
                        palindromeLenghth += (count & (int.MaxValue - 1)); // (count & (int.MaxValue - 1) 变为最近的偶数 等价为count / 2 * 2
                    }
                }
                else // 字母为双数
                {
                    palindromeLenghth += count;
                }
            }
            return palindromeLenghth;
        }


        public static int LongestPalindrome(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int palindromeLenghth = 0;
            for (int i = 0, imax = s.Length; i < imax; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], 0);
                }

                dic[s[i]] += 1;
            }

            foreach (int count in dic.Values)
            {
                palindromeLenghth += count / 2 * 2;
                if ((count & 1) == 1 && (palindromeLenghth & 1) == 0)
                {
                    palindromeLenghth++;
                }
            }

            return palindromeLenghth;
        }
    }
}
