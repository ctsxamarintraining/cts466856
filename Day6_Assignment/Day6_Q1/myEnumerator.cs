using System;
using System.Collections;

namespace Day6_Q1
{
	public class myEnumerator : IEnumerator
	{

		public Person[] data = null;
		int currentindex = -1;

		public bool MoveNext(){
			if (data.Length - 1 > currentindex) {
				currentindex++;
				return true;
			}
			return false;
		}
			
		public void Reset(){
			currentindex=-1;
		}
			
		public object Current{
			get{
				return (data[currentindex] as Person);
			}
		}





		public bool MoveBack(){
			if (currentindex > 0) {
				currentindex--;
				return true;
			}
			return false;
		}
		public void SetToLast(){
			currentindex=data.Length;
		}
	}
}

