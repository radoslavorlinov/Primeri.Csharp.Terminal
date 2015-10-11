using System;

namespace modul_02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a=0; int b; int sum;

			//Събиане на числа
			a=10; b=6; sum=a+b;
			//Писане в конзола
			Console.Write(a);
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine(sum);

			//Допълнителни оператори
			Console.WriteLine("\nUsing of +=");
			a += b; // a=a+b
			Console.WriteLine (a);

			Console.WriteLine("\nUsing of -=");
			a -= b; // a=a-b
			Console.WriteLine (a);

			Console.WriteLine("\nUsing of *=");
			a *= b; // a=a*b
			Console.WriteLine (a);

			Console.WriteLine ("Standartno delene: " + (7 / 3).ToString ()); //->2
			Console.WriteLine ("Standartno delene: " + (7 % 3).ToString ()); // остатък 1


			Console.ReadKey ();
		}
	}
}
