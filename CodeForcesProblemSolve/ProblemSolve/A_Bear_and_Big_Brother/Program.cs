using System;

namespace A_Bear_and_Big_Brother
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var data = line.Split(' ');
            var a = int.Parse(data[0]);
            var b = int.Parse(data[1]);

            var limak = a * 3;
            var bob = b * 2;
            

            if (limak < bob)
            {
                var result = bob  - limak;
                if (result > 2)
                {
                    Console.WriteLine(result / 2);

                }
                else
                {
                    Console.WriteLine(result);
                }
                
                
            }

            else if (limak >= bob)
            {
                var output = limak - bob;
                if (limak == bob)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine(output);
                }
                
            }

        }
    }
}
