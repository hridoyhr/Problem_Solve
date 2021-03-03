using System;

namespace A_Card_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var str = Console.ReadLine();

            var zero = 0;
            var one = 0;

            foreach (var c in str)
            {
                if (c == 'z')
                    zero++;
                if (c == 'n')
                    one++;
            }

            for (int i = 0; i < one; i++)
            {
                Console.Write("1 ");
            }
            for(int i = 0; i < zero; i++)
            {
                Console.Write("0 ");
                
            }
        }
    }
}
