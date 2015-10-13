/// <summary>
/// Write a program that reads an integer number and calculates and prints its square root.
/// If the number is invalid or negative, print "Invalid number”.
/// In all cases finally print "Goodbye". Use try-catch-finally.
/// </summary>

using System;

namespace Practice2Q1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int inputInt = 0;

			try {
				Console.WriteLine ("Enter an Integer to find it's SquareRoot: ");
				inputInt = Convert.ToInt32 (Console.ReadLine ());

				Console.WriteLine("\nThe SquareRoot of {0} is {1}",inputInt,Math.Sqrt(inputInt));

			} catch (FormatException) {	
				//Console.WriteLine ("Exception : {0}\ninput value must be a positive integer", fEx.Message);
				Console.WriteLine ("InvalidNumber");
			} catch(ArgumentException){
				//Console.WriteLine ("Exception : {0}\ninput value must be an integer", ArgEx.Message);
				Console.WriteLine ("InvalidNumber");
			}
			catch (Exception) {
				Console.WriteLine ("InvalidNumber");
			}
			finally{
				Console.WriteLine ("Goodbye");
			}

			Console.ReadLine ();
		}
	}
}
