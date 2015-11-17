//	Create a simple Linked list (MyLinkedList<T>) with following methods
//	void Add(T)
//	void Remove(T)
//	T Find(T)
//	int Count{get;set;}

using System;

namespace Generics_Q1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			Console.WriteLine("my list 1 - Add First:");
			Console.WriteLine ();
			LinkedList<string> myList1 = new LinkedList<string>();

			myList1.AddFirst("Hello");
			myList1.AddFirst("Magical");
			myList1.AddFirst("World");
			myList1.AddFirst ("This");
			myList1.AddFirst ("is");
			myList1.AddFirst ("Good");
			myList1.printAllNodes();

			Console.WriteLine();

			Console.WriteLine("my list 2 - Add Last:");
			Console.WriteLine ();
			LinkedList<string> myList2 = new LinkedList<string>();

			myList2.AddLast("Hello");
			myList2.AddLast("Magical");
			myList2.AddLast("World");
			myList2.AddLast ("This");
			myList2.AddLast ("is");
			myList2.AddLast ("Good");
			myList2.printAllNodes();


			Console.WriteLine("my list 1 - remove First:");
			Console.WriteLine ();

			myList1.RemoveFirst ();
			myList1.printAllNodes();

			Console.WriteLine("my list 2 - remove Last:");
			Console.WriteLine ();

			myList2.RemoveLast ();
			myList2.printAllNodes();


			Console.ReadLine();
			*/

			LinkedList<string> theList = new LinkedList<string>();

			theList.Add ("string1");
			theList.Add ("string2");
			theList.Add ("string3");
			theList.Add ("string4");
			theList.Add ("string5");

			foreach (var str in theList) {
				Console.WriteLine (str);
			}

			Console.ReadLine ();
		}
	}
}