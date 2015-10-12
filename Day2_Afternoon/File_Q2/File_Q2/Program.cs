using System;
using System.IO;
using System.Collections.Generic;

namespace File_Q2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string Directory_path = "Top_Level_Directory";

			if (!Directory.Exists (Directory_path)) {

				//////////////////////////////
				//	creating directories	//
				//////////////////////////////

				// create top level directory
				Directory.CreateDirectory (Directory_path);

				// "first" second level directory
				string Directory_path1 = Path.Combine (Directory_path, "Subfolder1");
				Directory.CreateDirectory (Directory_path1);

				// "third" level directories in subfolder 1
				string Directory_path1_1 = Path.Combine (Directory_path1, "Subfolder1_1");
				Directory.CreateDirectory (Directory_path1_1);

				string Directory_path1_2 = Path.Combine (Directory_path1, "Subfolder1_2");
				Directory.CreateDirectory (Directory_path1_2);

				// "second" second level directory
				string Directory_path2 = Path.Combine (Directory_path, "Subfolder2");
				Directory.CreateDirectory (Directory_path2);

				// "third" level directories in subfolder 2
				string Directory_path2_1 = Path.Combine (Directory_path2, "Subfolder2_1");
				Directory.CreateDirectory (Directory_path2_1);

				string Directory_path2_2 = Path.Combine (Directory_path2, "Subfolder2_2");
				Directory.CreateDirectory (Directory_path2_2);

				//////////////////////////
				//	creating new files	//
				//////////////////////////

				// thefile.txt in top level directory
				string file_path = "thefile.txt";
				file_path = Path.Combine (Directory_path, file_path);
				File.Create (file_path);

				// thefile.txt in SubFolder1
				string file1_path = "thefile1.txt";
				file1_path = Path.Combine (Directory_path1, file1_path);
				File.Create (file1_path);

				// thefile.txt in SubFolder2
				string file2_path = "thefile2.txt";
				file2_path = Path.Combine (Directory_path2, file2_path);
				File.Create (file2_path);

				// thefile.txt in SubFolder1_1
				string file1_1_path = "thefile1_1.txt";
				file1_1_path = Path.Combine (Directory_path1_1, file1_1_path);
				File.Create (file1_1_path);

				// thefile.txt in SubFolder1_2
				string file1_2_path = "thefile1_2.txt";
				file1_2_path = Path.Combine (Directory_path1_2, file1_2_path);
				File.Create (file1_2_path);

				// thefile.txt in SubFolder2_1
				string file2_1_path = "thefile2_1.txt";
				file2_1_path = Path.Combine (Directory_path2_1, file2_1_path);
				File.Create (file2_1_path);

				// thefile.txt in SubFolder2_2
				string file2_2_path = "thefile2_2.txt";
				file2_2_path = Path.Combine (Directory_path2_2, file2_2_path);
				File.Create (file2_2_path);
			}

			Console.WriteLine ("subfolders and files in top level directory are :\n\n");

			Dictionary<string,string> Dict = getContentswithPathString (Directory_path);
			Console.WriteLine ("index\t:\tContent");
			int index = 0;
			foreach (KeyValuePair<string,string> kvp in Dict) {
				Console.WriteLine ("  {0}\t:\t{1}", index, kvp.Key);
				index++;
			}

			Console.WriteLine ("\nsubfolders and files in subfolder2 are :\n\n");

			Dictionary<string,string> Dict1 = getContentswithPathString (Directory_path+'/'+"Subfolder2");
			Console.WriteLine ("index\t:\tContent");
			int index1 = 0;
			foreach (KeyValuePair<string,string> kvp in Dict1) {
				Console.WriteLine ("  {0}\t:\t{1}", index1, kvp.Key);
				index1++;
			}

			moveBetweenPaths (Directory_path+'/'+"Subfolder1",Directory_path+'/'+"Subfolder2");

			Console.WriteLine ("\n\nsubfolders and files in top level directory after movinf subfolder1 into subfolder2 are :\n\n");

			Dict = getContentswithPathString (Directory_path);
			Console.WriteLine ("index\t:\tContent");
			index = 0;
			foreach (KeyValuePair<string,string> kvp in Dict) {
				Console.WriteLine ("  {0}\t:\t{1}", index, kvp.Key);
				index++;
			}

			Console.WriteLine ("\nsubfolders and files in subfolder2 are :\n\n");

			Dict1 = getContentswithPathString (Directory_path+'/'+"Subfolder2");
			Console.WriteLine ("index\t:\tContent");
			index1 = 0;
			foreach (KeyValuePair<string,string> kvp in Dict1) {
				Console.WriteLine ("  {0}\t:\t{1}", index1, kvp.Key);
				index1++;
			}

			Console.ReadLine ();
		}

		public static Dictionary<string,string> getContentswithPathString (string Directory_path)
		{
			Dictionary<string, string> myDictionary = 
				new Dictionary<string, string> ();
			try {
				string[] Directory_Array = Directory.GetDirectories (Directory_path);
				string[] Files_Array = Directory.GetFiles (Directory_path);
				string[] contents = new string[Directory_Array.Length + Files_Array.Length];

				Array.Copy (Directory_Array, 0, contents, 0, Directory_Array.Length);
				Array.Copy (Files_Array, 0, contents, Directory_Array.Length, Files_Array.Length);

			

				foreach (string content in contents) {
					string[] str = content.Split ('/');
					myDictionary.Add (str [str.Length - 1], content);
				}
			} catch (Exception e) {
				Console.WriteLine ("\n{0}\n",e.Message);
			}

			return myDictionary;
		}

		public static void moveBetweenPaths (string sourcePath, string destinationPath)
		{
			string[] str = sourcePath.Split ('/');
			try{
				Directory.Move (sourcePath, destinationPath+'/'+str [str.Length - 1]);
			}
			catch(Exception e){
				Console.WriteLine ("\n{0}\n",e.Message);
			}
		}

	}
}
