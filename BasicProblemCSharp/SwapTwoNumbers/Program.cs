using System;

namespace SwapTwoNumbers
{
    class Program
    {
        public static string Swap(int a, int b)
        {
            string before = $"Before: a = {a}, b = {b}; ";
            int temp;

            temp = b;
            b = a;
            a = temp;

            string after = $"After: a = {a}, b = {b}";
            return before + after;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Swap(45, 65));
            Console.WriteLine(Swap(55, 85));
        }
    }
}
