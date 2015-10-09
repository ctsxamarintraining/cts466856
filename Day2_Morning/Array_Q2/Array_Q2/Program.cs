using System;

namespace Array_Q2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[,] newArray = new int[5,2]{ {2,3},{5,7},{8,2},{9,1},{1,0}};
			Print_Array (newArray);
		}

		static void Print_Array(Array theArray){
			foreach (var elememt in theArray)
				Console.WriteLine (elememt);
		}
	}
}
