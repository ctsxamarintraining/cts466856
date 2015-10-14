/// <summary>
/// Create anonymous type with properties Name, Id and City and print them in console. 
/// </summary>

using System;
using System.Collections.Generic;

namespace Day5_Q4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<Person> PersonList = new List<Person> {
				new Person { Id = 1, Name = "Adithya", City = "Amsterdam" },
				new Person { Id = 2, Name = "Chinni", City = "Amberpet" },
				new Person { Id = 3, Name = "Nishanth", City = "Hyderabad" },
			};

			foreach (Person thePerson in PersonList) {
				Console.WriteLine (
					"\nThe Person's Name : \t{0}\n" +
					"The Person's Id : \t{1}\n" +
					"The Person's City : \t{2}\n", thePerson.Name, thePerson.Id, thePerson.City
				);
			}
		}
	}
}
