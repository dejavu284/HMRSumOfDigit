using System;

namespace HMRSumOfDigit
{
    class Program
    {
        static int SumOf(int value)
        {
            if (value < 10)
                return value;
            return value % 10 + SumOf(value /= 10);
        }
        static void Main(string[] args)
        {
            int sum = SumOf(561199);
            Console.WriteLine(sum);
            float max = float.MaxValue;
            double Max = double.MaxValue;
            float s = (float)Max;
            Console.WriteLine(s);
            Console.WriteLine(max);
        }
    }
}
