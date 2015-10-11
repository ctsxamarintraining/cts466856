using System;
using System.IO;
using System.Collections.Generic;

namespace File_Q1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			//File.Create ("NewFile.txt");
			File.Delete("NewFile.txt");
			File.Delete("NewFile2.txt");
			using (StreamWriter source_FileWriter = new StreamWriter ("NewFile.txt")) {
				source_FileWriter.WriteLine ("This is the first Line");
				source_FileWriter.WriteLine ("This is the second Line");
				source_FileWriter.WriteLine ("This is the third Line");
				source_FileWriter.WriteLine ("This is the fourth Line");
				source_FileWriter.WriteLine ("This is the fifth Line");
			}

			Console.WriteLine ("\n----- source file -----\n");

			using (StreamReader source_StreamReader2 = new StreamReader ("NewFile.txt")) {
				Console.WriteLine (source_StreamReader2.ReadToEnd());
			}



			List<string> lines = new List<string>();
			using (StreamReader source_StreamReader = new StreamReader("NewFile.txt"))
			{
				string line;
				while ((line = source_StreamReader.ReadLine()) != null)
				{
					lines.Add(line); 
				}
			}

			lines.Reverse();

			using (StreamWriter destination_StreamWriter = new StreamWriter ("NewFile2.txt")) {
				foreach (string line in lines) {
					destination_StreamWriter.WriteLine (line);
				}
			}


			Console.WriteLine ("\n----- destination file -----\n");
			using (StreamReader destination_StreamReader = new StreamReader ("NewFile2.txt")) {
				Console.WriteLine (destination_StreamReader.ReadToEnd());
			}
			Console.ReadLine ();
		}
	}
}
