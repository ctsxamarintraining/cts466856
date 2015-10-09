//	Create a custom type Person with FirstName, LastName and Age properties.
//	Write a re-usable function that can Sort this Person[] Array by age. 
//	Hint: Use IComparable and Array.Sort(arrObj)


using System;
using System.Collections;

namespace Array_Q3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person[] P_Array = new Person[] {new Person ("Jack", "Osword", 21),
				new Person ("Jack", "Daniels", 20),
				new Person ("Nishanth", "Vemula", 22),
				new Person ("Nikhil", "Ransoth", 34),
				new Person ("Kisame", "Hishigaki", 28),
				new Person ("Lewis", "Norman", 29),
				new Person ("Kane", "Wills", 25),
			};



			Console.WriteLine ("-------- before sorting ----------");

			for (int index = 0; index < P_Array.Length; index++) {

				Console.WriteLine (P_Array [index].Age);
			}

			P_Array = Sort_Person_Array (P_Array);

			Console.WriteLine ("-------- after sorting ----------");

			for (int index = 0; index < P_Array.Length; index++) {
				Console.WriteLine (P_Array [index].Age);
			}
		}

		public static Person[] Sort_Person_Array (Person[] PersonArray)
		{
			
			Array.Sort (PersonArray);
			return PersonArray;

		}
	}
}
