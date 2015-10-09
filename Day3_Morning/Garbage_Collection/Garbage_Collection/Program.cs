using System;

namespace Garbage_Collection
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Console.WriteLine ("Memory at begining : {0}", GC.GetTotalMemory (false));

			int[] values = new int[500000]{null};

			Console.WriteLine ("Memory after introducing a value of type int[500000] : {0}", GC.GetTotalMemory (false));

			GC.Collect ();

			Console.WriteLine ("Memory after collecting garbage : {0}", GC.GetTotalMemory (false));

		}
	}
}
