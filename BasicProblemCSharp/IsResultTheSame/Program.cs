using System;

namespace IsResultTheSame
{
    class Program
    {
        public static bool IsResultSame(double a, double b)
        {
            return a == b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsResultSame(3 * 3, 18 /2));
            Console.WriteLine(IsResultSame(3 * 3, 18 /2));
            Console.WriteLine(IsResultSame(3 * 9, 18 /2));
        }
    }
}
