//	Arrays Q.4
//
//	Write a common function that can Sort Person[] Array on the property of our choice
//	Hint: Use Array.Sort(arrObj, IComparer)

using System;

namespace Array_Q4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person[] pArray = new Person[] {
				new Person ("Rohit", 27),
				new Person ("Nishanth", 22),
				new Person ("jack", 37),
				new Person ("Adil", 17)
			};

			Console.WriteLine ("----- Before sorting -----");

			for (int i = 0; i < pArray.Length; i++) {

				Console.WriteLine (pArray [i].name);
			}

			Array.Sort (pArray, Person.SortByName);

			Console.WriteLine ("----- after sorting by Name-----");

			for (int i = 0; i < pArray.Length; i++) {

				Console.WriteLine (pArray [i].name);
			}
		}
	}
}
