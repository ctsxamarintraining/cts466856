using System;
using System.Collections;

namespace Array_Q4
{
	public class Person
	{
		public string name{ set;get;}
		public int age{ set; get;}

		public Person ( string name, int age)
		{
			this.name = name;
			this.age = age;
		}
		public static IComparer SortByName
		{
			get
			{
				return((IComparer) new SortPersonsByName());
			}
		}
	}
}

