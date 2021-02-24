using System;

namespace TheCube_Of
{
    class Program
    {
        public static double Cube(double num)
        {
            return num * num * num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Cube(2));
            Console.WriteLine(Cube(-5.5));
            Console.WriteLine(Cube(5));
        }
    }
}
