using System;
using System.Collections;

namespace OrderedArrayImplementation
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] newList = { 12, 16, 20, 40, 50, 70 };
			//OrderedArray myOrderedArray = new OrderedArray(newList);
			//myOrderedArray.Insert(26);
			var prueba = new ArrayList(10);
			Console.WriteLine("List:");
			for (int i = 0; i < prueba.Count; i++)
			{
				Console.WriteLine(prueba[i]);
			}
			Console.WriteLine("List2:");
			for (int i = 0; i < prueba.Capacity; i++)
			{
				Console.WriteLine(2);
			}
		}
	}
}
