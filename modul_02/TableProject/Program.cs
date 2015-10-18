using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] row = new string[3];
			row [0]="Row 1";
			row [1]="Row 2";	
			row [2]="Row 3";

			Console.WriteLine ("Masiv row: " + row[0] + ", " + row[1] + ", " + row[2] + "\n");

			string[] parse = "0,1,2,3,4,5,6,7,8,9".Split (',');
			Console.WriteLine ("Masive:\n"+"1,2,3,4,5,6,7,8,9\n\ne: " + parse.Length);

			string list1 = string.Join (",", parse);
			Console.WriteLine ("list1 = "+list1+"\n");
			//Console.ReadKey ();
			int massL=10;
			int[] mass1=new int[massL];
			for (int i = 0; i < massL; i++) {
				mass1 [i] = i;
				Console.WriteLine (mass1[i]+" i="+i);
			}
			for (int i = massL-1; i >= 0; i--) {
				Console.Write (mass1[i]);
			}
			Console.WriteLine ("\nL=" + mass1.Length);
			string massS = string.Join (",",mass1);
			bool caseS = string.Equals (list1, massS);
			Console.WriteLine ("string = " + massS+"\n Equal="+caseS);
		}
	}
}
