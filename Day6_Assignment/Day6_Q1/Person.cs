using System;

namespace Day6_Q1
{
	public class Person
	{
		public int Id { get; set;}
		public string Name { get; set;}
		public string Location { get; set;}

		public Person (int theId,string theName, string theLocation)
		{
			Id = theId;
			Location = theLocation;
			Name = theName;
		}
	}
}

