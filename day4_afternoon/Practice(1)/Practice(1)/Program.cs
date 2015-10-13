using System;

namespace Practice1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] intArray = new int[10];
			int index = 0;
			while (true) {
				try {
					Console.WriteLine("Enter an Integer : ");
					intArray [index] = Convert.ToInt32 (Console.ReadLine ());

					Console.WriteLine ("\nThe array is : \n");

					for (int tempindex = 0; tempindex < index; tempindex++) {
						Console.Write ("{0},", intArray [tempindex]);
					}
					Console.Write ("{0}\n\n", intArray [index]);
					index++;


				} catch (FormatException fEx) {	
					Console.WriteLine ("Exception : {0}\ninput value must be an integer",fEx.Message);
					break;
				} catch (IndexOutOfRangeException indexEx) {
					Console.WriteLine ("Exception : {0}\nProgram reached beyond the scope of input array\n",indexEx.Message);
					break;
				} catch (Exception Ex) {
					Console.WriteLine (Ex.Message);
					break;
				}
			}
			Console.ReadLine ();
		}
	}
}
