using System;
using System.Collections;

namespace Array_Q4
{
	public class SortPersonsByName: IComparer
	{
		public int Compare(object obj1, object obj2)
		{
			if (obj1 is Person && obj2 is Person) {
				return(String.Compare ((obj1 as Person).name,(obj2 as Person).name));
			}
			throw new ArgumentException("Object is not a person");
		}
	}
}

