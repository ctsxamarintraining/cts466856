/// <summary>
/// Implement double LinkedList for a Person class (which contains Id, Name , Location properties).
/// use enumerator to iterate through each item and print the values on console.
/// Note: Dont not use any default classes, only use either IEnumerable/IEnumerator.
/// </summary>

using System;


namespace Day6_Q1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			myEnumerable enumerableobj = new myEnumerable ();
			myEnumerator enumerator = (enumerableobj.GetEnumerator () as myEnumerator);
			enumerator.data = new Person[]{
				new Person(1,"Nishanth","Hyderabad"),
				new Person(2,"Adwaith","Chennai"),
				new Person(3,"Adithya","Bangalore"),
				new Person(4,"Nikhil","Ahmedabad"),
				new Person(5,"Prabhakar","Venice"),
				new Person(6,"Kisame","Rome"),
				new Person(7,"Chinni","Moinabad"),
				new Person(8,"Krishna","Los Angles"),
				new Person(9,"Rohit","Hyderabad")
			};

			Console.WriteLine ("Moving forward through Doubly linked list :\n\n");

			while (enumerator.MoveNext ()) {
				Person thePerson = enumerator.Current as Person;
				Console.WriteLine ("Id : {0}",thePerson.Id);
				Console.WriteLine ("Name : {0}",thePerson.Name);
				Console.WriteLine ("Location : {0}\n",thePerson.Location);
			}

			Console.WriteLine ("\nCurrent element is last element of the linked list.\n\nMoving backward through Doubly linked list :\n\n");

			bool movebackbool = true;

			while (movebackbool) {
				Person thePerson = enumerator.Current as Person;
				Console.WriteLine ("Id : {0}",thePerson.Id);
				Console.WriteLine ("Name : {0}",thePerson.Name);
				Console.WriteLine ("Location : {0}\n",thePerson.Location);
				movebackbool = enumerator.MoveBack ();
			}

			Console.WriteLine ("\nCurrent element is first element of the linked list.");

			enumerator.SetToLast ();

			Console.WriteLine ("Called So set to last method");

			Console.WriteLine ("Moving backward through Doubly linked list :\n\n");

			while (enumerator.MoveBack ()) {
				Person thePerson = enumerator.Current as Person;
				Console.WriteLine ("Id : {0}",thePerson.Id);
				Console.WriteLine ("Name : {0}",thePerson.Name);
				Console.WriteLine ("Location : {0}\n",thePerson.Location);
			}
		}
	}
}