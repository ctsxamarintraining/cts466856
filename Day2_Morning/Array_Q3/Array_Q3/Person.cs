using System;

namespace Array_Q3
{
	public class Person: IComparable
	{
		public string FirstName{ get; set; }

		public string LastName{ get; set; }

		public int Age{ get; set; }

		public Person (string fname,string lname, int age)
		{
			this.LastName = lname;
			this.FirstName = fname;
			this.Age = age;
		}

		public int CompareTo (object obj)
		{
			if (obj is Person) {
				return this.Age.CompareTo ((obj as Person).Age);  // compare person age
			}
			throw new ArgumentException ("Object is not a Person");
		}
	}
}

