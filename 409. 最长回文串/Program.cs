namespace _409._最长回文串
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = LongestPalindrome("abccccdd");
            Console.WriteLine(num);
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
