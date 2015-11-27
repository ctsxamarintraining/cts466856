using System;

namespace BinarySearchTreeConsole
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			BinarySearchTree TheBST = new BinarySearchTree ();
			if (TheBST.Add (10)) {
				Console.WriteLine ("Added 10");
			} else {
				Console.WriteLine ("Could Not Add 10 as it is already present");
			}
			if (TheBST.Add (15)) {
				Console.WriteLine ("Added 15");
			} else {
				Console.WriteLine ("Could Not Add 15");
			}
			if (TheBST.Add (18)) {
				Console.WriteLine ("Added 18");
			} else {
				Console.WriteLine ("Could Not Add 18");
			}
			if (TheBST.Add (12)) {
				Console.WriteLine ("Added 12");
			} else {
				Console.WriteLine ("Could Not Add 12");
			}
			if (TheBST.Add (17)) {
				Console.WriteLine ("Added 17");
			} else {
				Console.WriteLine ("Could Not Add 17");
			}
			if (TheBST.Add (7)) {
				Console.WriteLine ("Added 7");
			} else {
				Console.WriteLine ("Could Not Add 70");
			}


			if (TheBST.Search (17)) {
				Console.WriteLine ("found node containing 17. Verifiying its value {0}", TheBST.current_Node.NodeValue);
			} else {
				Console.WriteLine ("not found 17");
			}

			TheBST.Delete (17);

			if (TheBST.Search (17)) {
				Console.WriteLine ("found node containing 17. Verifiying its value {0}", TheBST.current_Node.NodeValue);
			} else {
				Console.WriteLine ("not found 17");
			}
			if (TheBST.Search (10)) {
				Console.WriteLine ("found node containing 10. Verifiying its value {0}", TheBST.current_Node.NodeValue);
			} else {
				Console.WriteLine ("not found 10");
			}

			Console.ReadLine ();
		}
	}
}
