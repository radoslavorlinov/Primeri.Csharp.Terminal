using System;

namespace Zad1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string h="Hello"; string w=" World"; string a; string b;
			object sum = h+w;

			Console.WriteLine (sum);

			Console.WriteLine ("Vuvedete 1 znak:");
			a = Console.ReadLine();
			Console.WriteLine ("Vuvedete duma:");
			b = Console.ReadLine();
			sum = a + b;
//			a = Convert.ToString(Console.ReadKey());
			Console.WriteLine (sum);

		}
	}
}
