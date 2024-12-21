namespace _165._比较版本号
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public static int CompareVersion(string version1, string version2)
        {
            int v1Lenghth = version1.Length;
            int v2Lenghth = version2.Length;
            int i = 0;
            int j = 0;

            while (i < v1Lenghth || j < v2Lenghth) 
            {
                int x = 0;
                for (; i < v1Lenghth; i++) 
                {
                    if (version1[i] == '.') 
                    {
                        i++;
                        break;
                    }
                    x = x * 10 + (version1[i] - '0');
                }

                int y = 0;
                for (; j < v2Lenghth; j++) 
                {
                    if (version2[j] == '.') 
                    {
                        j++;
                        break;
                    }
                    y = y * 10 + (version2[j] - '0');
                }

                if (x < y) 
                {
                    return -1;
                }
                if (x > y) 
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
