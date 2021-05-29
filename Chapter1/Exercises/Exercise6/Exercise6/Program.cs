using System;

namespace Exercise6
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] array = {1, 2, 3, 4, 5,6};
			var mySet = new ArrayBasedSet(array);

			mySet.Insert(7, 2);
			mySet.Insert(1, 0);
			mySet.Delete(0);
			mySet.Delete(10);
			mySet.ReadSet();
			Console.WriteLine($"Searching the value: 4 find in: {mySet.Search(4)} index");
		}
	}
}
