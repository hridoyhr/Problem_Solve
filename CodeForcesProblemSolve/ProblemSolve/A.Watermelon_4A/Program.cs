using System;

namespace A.Watermelon_4A
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input <= 2)
            {
                Console.WriteLine("NO");
            }
            else if (input % 2 ==  0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
