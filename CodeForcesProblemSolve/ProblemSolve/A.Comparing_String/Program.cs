using System;

namespace A.Comparing_String
{
    class Program
    {
        

        static int Main(string[] args)
        {
			string s1 = new string(new char[100005]);
			string s2 = new string(new char[100005]);
			string tempVar = Convert.ToString(Console.ReadLine());

			if (tempVar != null)
            {
				s1 = tempVar;
			}

			string tempVar2 = Convert.ToString(Console.ReadLine());
			if (tempVar2 != null)
			{
				s2 = tempVar2;
			}

			int flag = 0;
			int[] a = new int[100005];
			int temp = 0;
			for (int t = 0; t < s1.Length; t++)
			{

				if (s1.Length != s2.Length)
				{
					flag = 3;
				}
				if (s1[t] != s2[t])
				{
					a[temp] = t;
					temp++;
					flag++;
					if (flag == 3)
						break;
				}
				else
					continue;
			}
			if (flag == 2)
			{
				if (s1[a[0]] == s2[a[1]] && s1[a[1]] == s2[a[0]])
				{
					Console.Write("YES\n");
				}
				else
				{
					Console.Write("NO\n");
				}
			}
			else
			{
				Console.Write("NO\n");
			}

			return 0;
		}
    }
}
