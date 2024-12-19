using System.Diagnostics;

namespace FixVal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixVal a1 = new FixVal(1.6f);  // 表示定点数格式的1.5
            FixVal a2 = new FixVal(1.5f);  // 表示定点数格式的1.5
            double val = (double)(a1 * a2);        // 转换回浮点数 val = 1.5
            Console.WriteLine(val);
            Console.WriteLine("Hello, World!");
        }
    }

    class FixVal
    {

        const int total_bit_cnt = 64;

        const int f_bit_cnt = 16;

        const int i_bit_cnt = total_bit_cnt - f_bit_cnt;

        const long f_mask = (long)(ulong.MaxValue >> i_bit_cnt);

        const long i_mask = (long)(-1L & ~f_mask);

        const long f_range = f_mask + 1;

        public const long min_val = long.MinValue >> f_bit_cnt;
        public const long max_val = long.MaxValue >> f_bit_cnt;

        long mRaw;

        public FixVal(int intVal) : this(((long)intVal) << f_bit_cnt)
        {

        }

        public FixVal(float raw)
        {
            mRaw = (long)(f_range * raw + 0.5f);
        }

        public FixVal(long raw)
        {
            mRaw = raw;
        }

        public long GetRaw()
        {
            return mRaw;
        }

        public static FixVal operator +(FixVal a, FixVal b)
        {
            return new FixVal(a.mRaw + b.mRaw);
        }

        public static FixVal operator -(FixVal a, FixVal b)
        {
            return new FixVal(a.mRaw - b.mRaw);
        }

        public static FixVal operator *(FixVal a, FixVal b)
        {
            return new FixVal((a.mRaw * b.mRaw + (f_range >> 1)) >> f_bit_cnt);
        }

        public static FixVal operator /(FixVal a, FixVal b)
        {
            return new FixVal((a.mRaw << f_bit_cnt) / b.mRaw);
        }

        public static explicit operator double(FixVal fixVal)
        {
            return (double)(fixVal.mRaw >> f_bit_cnt) + (fixVal.mRaw & f_mask) / (double)f_range;
        }
    }
}
