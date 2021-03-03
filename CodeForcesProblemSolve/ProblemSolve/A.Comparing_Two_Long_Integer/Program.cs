using System;

namespace A.Comparing_Two_Long_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = (int)Convert.ToInt64(Console.ReadLine());
            int input2 = (int)Convert.ToInt64(Console.ReadLine());

 
            if (input1 < input2)
            {
                Console.WriteLine("<");
            }
            else if (input1 > input2)
            {
                Console.WriteLine(">");
            }
            else if (input1 == input2)
            {
                Console.WriteLine("=");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
