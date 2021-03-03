using System;

namespace A.WayTooLongWords_71A
{
    class Program
    {
        static void Main(string[] args)
        {
			

			int n;
			string s;
			n = int.Parse(Console.ReadLine());
			while ((n--) != 0)
			{
				s = Console.ReadLine();
				if (s.Length > 10)
				{
					Console.Write(s[0]);
					Console.Write(s.Length - 2);
					Console.Write(s[s.Length - 1]);
					Console.WriteLine();
				}
				else
				{
					Console.Write(s);
                    Console.WriteLine();
				}
			}

		}
    }
}
