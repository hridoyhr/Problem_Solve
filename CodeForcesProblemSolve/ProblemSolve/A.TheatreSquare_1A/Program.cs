using System;

namespace A.TheatreSquare_1A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');

            long n = int.Parse(tokens[0]);
            long m = int.Parse(tokens[1]);
            long a = int.Parse(tokens[2]);
 
            Console.Write((((n + a - 1) / a) * ((m + a - 1) / a)));
        }
    }
}
