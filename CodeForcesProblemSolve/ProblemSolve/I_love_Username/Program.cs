using System;

namespace I_love_Username
{
    class Program
    {
        static int Main(string[] args)
        {
			int n =0;
			int i;
			int cnt = 0;
			string tempVar = Console.ReadLine();
			if (tempVar != null)
			{
				n = int.Parse(tempVar);
			}
			int[] a = new int [n];
			for (i = 0; i < n; i++)
			{
				string tempVar2 = Console.ReadLine();
				if (tempVar2 != null)
				{
					a[i] = Convert.ToInt32(tempVar2);
				}
			}
			int maxx = a[0];
			int minn = a[0];
			for (i = 0; i < n; i++)
			{
				if (a[i] > maxx)
				{
					maxx = a[i];
					cnt++;
				}
				if (a[i] < minn)
				{
					minn = a[i];
					cnt++;
				}
			}
			Console.Write("{0:D}\n", cnt);

			return 0;
		}
    }
}
