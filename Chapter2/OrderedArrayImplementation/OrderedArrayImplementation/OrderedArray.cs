using System;

namespace OrderedArrayImplementation
{
	public class OrderedArray
	{
		private int[] orderedArray = new int[20];
		public OrderedArray(int[] newList)
		{
			int before = -10000;
			for (int i = 0; i < orderedArray.Length; i++)
			{
				if (before > orderedArray[i])
				{
					orderedArray = new int[20];
					Console.WriteLine("The ordered array only can contain growing values.");
					break;
				}
				else
				{
					orderedArray[i] = newList[i];
					before = newList[i];
				}
			}
		}
		public void Read()
		{
			foreach (var item in orderedArray)
			{
				Console.WriteLine(item);
			}
		}
		public int Insert(int newValue)
		{
			// [12, 16, 20, 40, 50, 70].Count = 6 || newValue = 26, 0, 77
			int i, n=orderedArray.Length;
			for (i = n - 1; (i >= 0 && (int)orderedArray[i] > newValue); i--)
			{
				orderedArray[i + 1] = orderedArray[i];
			}
			orderedArray[i + 1] = newValue;
			return (n + 1);
		}

	}
}
