using System;

namespace ModuloOperations
{
    class Program
    {
        public static int Modules(int a, int b, int c)
        {
            return a % b % c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Modules(33, 5, 4));
            Console.WriteLine(Modules(40, 8, 2));
            Console.WriteLine(Modules(33, 5, 4));
        }
    }
}
