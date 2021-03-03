using System;

namespace A.Is_it_rated
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string[] input = new string[num];
            int[] array1 = new int[num];
            int[] array2 = new int[num];

            for (var i = 0; i < num; i++)
            {
                input[i] = Console.ReadLine();
            }
            
            for(var i = 0; i < num; i++)
            {
                var split = input[i].Split(' ');
                array1[i] = Convert.ToInt32(split[0]);
                array2[i] = Convert.ToInt32(split[1]);

                if (array1[i] != array2[i])
                {
                    Console.WriteLine("rated");
                    break;
                }

            }

            for (var i = 0; i < num; i++)
            {
                var split = input[i].Split(' ');
                array1[i] = Convert.ToInt32(split[0]);
                array2[i] = Convert.ToInt32(split[1]);

                if (array1[0] > array1[i] && array1[i] == array2[2])
                {
                    Console.WriteLine("unrated");
                    break;
                }

            }

            for (var i = 0; i < num; i++)
            {
                var split = input[i].Split(' ');
                array1[i] = Convert.ToInt32(split[0]);
                array2[i] = Convert.ToInt32(split[1]);

                if (array1[0] != array1[i] && array1[i] == array2[2])
                {
                    Console.WriteLine("maybe");
                    break;
                }

            }

        }
        

    }
}
