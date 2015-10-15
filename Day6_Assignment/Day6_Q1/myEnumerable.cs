using System;
using System.Collections;

namespace Day6_Q1
{
	public class myEnumerable : IEnumerable
	{
		public IEnumerator GetEnumerator ()
		{
			return new myEnumerator ();
		}
	}
}

