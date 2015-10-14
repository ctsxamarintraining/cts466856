using System;

namespace Day5_Q1
{
	public static class ExtensionMethods
	{
		public static int getNumberOfWords (this string str)
		{
			while (str.Contains ("  ")) {
				str = str.Replace ("  ", " ");
			}
			return (str.Split (' ')).Length;
		}

		public static int getCharCountExcludingWhiteSpaces (this string str)
		{
			str = str.Replace (" ","");
			return str.Length;
		}
	}
}
