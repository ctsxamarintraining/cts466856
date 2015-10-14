/// <summary>
/// Create delegate and assign anonymous method to it and execute the method using delegate.
/// </summary>
using System;

namespace Day5_Q3
{
	public delegate void delegateMethod();

	class MainClass
	{
		public static void Main (string[] args)
		{
			delegateMethod del = delegate {
				Console.WriteLine("Give me your name :\n");
				Console.WriteLine("\nThe anonymous delegate method is called by : {0}",(Console.ReadLine()).ToUpper());
			};
			del ();

			Console.ReadLine ();
		}
	}
}
