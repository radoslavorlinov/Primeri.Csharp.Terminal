using System;

namespace Read_from
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 5, b = 0;

			//Въвеждане на входни данни
			Console.Write ("b = ");
			b = Convert.ToInt32 (Console.ReadLine ());

			//Печат на резултат
			//Console.Write ("a + b = ");
			Console.WriteLine ("a + b = " + (a + b).ToString() + "\n");

			string test = "1";

			test += ", 2";
			test += ", 3";
			test += ", 4";

			Console.WriteLine ("Subirane s =+ : " + test + "\n");

			test = test.Replace (", ", ";");

			Console.WriteLine ("Rabota s .Replase: " + test + "\n");

			Console.WriteLine ("Treti znak: " + test.Split(';')[2] + "\n");

			Console.ReadKey ();

		}
	}
}
