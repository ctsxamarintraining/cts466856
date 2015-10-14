/// <summary>
///  Write extension Methods for string for getting no of words, No of characters without white spaces.
/// </summary>

using System;

namespace Day5_Q1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("enter a string : ");
			string str = Console.ReadLine ();
			Console.WriteLine ("Number of words : {0}",str.getNumberOfWords());
			Console.WriteLine ("Number of characters (excluding white spaces) : {0}",str.getCharCountExcludingWhiteSpaces());
		}
	}
}


