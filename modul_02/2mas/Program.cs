using System;

namespace mas
{
	class MainClass
	{
		//dava nomeracia na ti.* i informacia
		enum ti {ime=0, familia, godini};

		public static void Main (string[] args)
		{
			//definirene na tablica
			string[,] table = new string[2, 3];
			//1vi red
			table[0,(int)ti.ime]="Martin";	table[0,(int)ti.familia]="Sim";		table[0,(int)ti.godini]="30";
			table[1,(int)ti.ime]="Petur";	table[1,(int)ti.familia]="Zambov";	table[1,(int)ti.godini]="41";

			Console.Write ("row?");
			//string from console to integer
			int _index = Convert.ToInt32 (Console.ReadLine ());
			//verification of entered nuber row
			while (_index > 2||_index<1) {
				Console.WriteLine ("NA Row?");
				_index = Convert.ToInt32 (Console.ReadLine ());
			}
			//може да се изкара само един знак от стринга
			Console.WriteLine ((table [_index-1, (int)ti.ime]) [0] + ". " + table [_index-1, (int)ti.familia] + ", " + table [_index-1, (int)ti.godini]);
		}
	}
}
