using System;

namespace Modul03
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//double - дробни числа
			double a = 0, b = 0, c = 0, d=0, e=0;

			//vuvejdane na a i b i convert v double
			Console.Write ("> a = ");	a = Convert.ToDouble (Console.ReadLine ());
			Console.Write ("> b = ");	b = Convert.ToDouble (Console.ReadLine ());

			//formatirane s dimensia
			string _format="#0.00 m3";
			// delene na a/b i formatirane v ToString
			Console.WriteLine ("\n\n>a / b = " + (a / b).ToString (_format));
			//Stepenuvane
			c=Math.Pow(a,b);
			Console.WriteLine("\na^b = " + c.ToString (_format));
			//Sqrt
			d=Math.Sqrt(b);
			Console.WriteLine("\nb^0.5 = " + d.ToString (_format));
			//Round 1 znak
			e=Math.Round(a/b,1);
			Console.WriteLine("\na/b (round) = " + e.ToString (_format));
		}
	}
}
