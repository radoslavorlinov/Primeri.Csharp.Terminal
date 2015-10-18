using System;

namespace rotat
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] row = { "A", "B", "C" };
			var r = new Random ();
			int a1 = r.Next (0, 3);
			int a2 = r.Next (0, 3);
			while (a2 == a1) {
				a2 = r.Next (0, 3);
			}
			int a3 = r.Next (0, 3);
			while (a3 == a1 || a3==a2) {
				a3 = r.Next (0, 3);
			}
			Console.WriteLine (a1 + " " + a2 + " " + a3);
			Console.WriteLine (row [a1] + " " + row [a2] + " " + row [a3]);
		}
	}
}
