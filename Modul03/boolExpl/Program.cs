using System;

namespace boolExpl
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//bool _b = true;

			//bool _test = 5 > 10;

			//масив с три елемента
			int[] _i = new int[] { 4, 3, 2 };

			//променлива която да изведе един от трите елемента
			int _ui = Convert.ToInt32 (Console.ReadLine ());

			//масив за 2 проверки
			bool[] _check = new bool[2];

			//дефиниране на двете проверки

			_check[0] = _ui <= _i.Length;
			_check[1] = _ui > 0;

			//Трябва и двата израза да са True за да е True
			bool _exp01 = _check [0] && _check [1];
			//Трябва поне един да е Truе за да е True
			bool _exp02 = _check [0] || _check [1];
			bool _exp03 = !_check [0];

			Console.WriteLine ("Logical &" + _exp01.ToString());
			Console.WriteLine ("Logical ||" + _exp02.ToString());
			Console.WriteLine ("Otricanie na" + _check [0].ToString() + " e " + _exp03.ToString ());

			//Console.WriteLine (_i [_ui - 1]);
		}
	}
}
