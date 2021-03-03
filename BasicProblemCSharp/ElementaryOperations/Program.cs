using System;

namespace ElementaryOperations
{
    class Program
    {
        public static string Elementary(int a, int b)
        {
            int addition = a + b;
            int substraction = a - b;
            int multiplication = a * b;
            double division;

            if (b != 0)
            {
                division = a / (double)b;
            }
            else //assume that division by 0 return 0.
            {
                division = 0;
            }

            return String.Format($"a + b = {addition}, a - b = {substraction}, a * b = {multiplication}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Elementary(36, 15));
            Console.WriteLine(Elementary(-375, 24));
        }
    }
}
