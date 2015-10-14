/// <summary>
/// Create the partial classes in two file with two methods each. And call them in main method.
/// </summary>

using System;

namespace Day5_Q5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			NewPartialClass theObject = new NewPartialClass();
			theObject.Printfromfile1 ();
			theObject.Printfromfile2 ();
			Console.ReadLine ();
		}
	}
}
