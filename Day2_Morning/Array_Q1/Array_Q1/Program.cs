//	Q.1
//
//	Write a re-usable function that can iterate and output all elements of a Multidimensional Primitive Type Array.
//	The function should be able to take an Array of any dimension as a parameter

using System;

namespace Array_Q1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,,,] stringArray_4D = new string[2,2,2,2]{	//Dimension 1
																{	//dimension 2
																	{	//dimension 3
																		{"one","two"},{"three","four"}
																	},
																	{	//dimension 3
																		{"five","six"},{"seven","eight"}
																	},
																},

																{	//dimension 2
																	{	//dimension 3
																		{"nine","ten"},{"eleven","twelve"}
																	},
																	{	//dimension 3
																		{"thirteen","fourteen"},{"fifteen","sixteen"}
																	},
																},
															};

			for(int count0=0;count0<2;count0++)
				for(int count1=0;count1<2;count1++)
					for(int count2=0;count2<2;count2++)
						for(int count3=0;count3<2;count3++)
							Console.WriteLine(stringArray_4D[count0,count1,count2,count3]);
		}
	}
}
