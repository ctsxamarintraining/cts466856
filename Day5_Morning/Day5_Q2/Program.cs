/// <summary>
/// Create Nullable Type. Assign null and to print value in console. Assign a value and print value in console.
/// </summary>
using System;

namespace Day5_Q2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int? nullableInt = null;
			Console.WriteLine ("the initial value of nullable integer variable : {0}",nullableInt);
			nullableInt=20;
			Console.WriteLine ("the final (after assigning 20) value of nullable integer variable : {0}",nullableInt);

		}
	}
}
