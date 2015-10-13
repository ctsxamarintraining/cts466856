/// <summary>
/// Write a program that enters filename along with its full file path
/// (e.g c:\Example\myexample.txt ),
/// reads its contents and prints it on the console.
/// Find in MSDN how to use System.IO.File.ReadAllText(…).
/// Besure to catch all possible exceptions and print user-friendly error messages
/// </summary>

using System;
using System.IO;

namespace Practice2Q2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string filename = "example.txt";
			if (!File.Exists (filename)) {
				FileStream fs = File.Create (filename);
				fs.Close ();
				using (StreamWriter sw = new StreamWriter (filename)) {
					for (int index = 0; index < 100; index++) {
						sw.WriteLine ("this is Line : {0} in file {1}.",index,filename);
					}
				}
			}

			Console.WriteLine ("File name : {0}",filename);
			Console.WriteLine ("File path : {0}\n\n",Path.GetFullPath(filename));

			Console.WriteLine( "Contents of the above file :\n"+File.ReadAllText (filename));
		}
	}
}
