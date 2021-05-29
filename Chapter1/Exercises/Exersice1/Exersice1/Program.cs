using System;

namespace Exersice1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int size = 100;
			int[] array = FillArray(size, 150);

			// 1. Reading:
			Console.WriteLine("1. Reading");
			Console.WriteLine($"Position 10 have the value of: " + array[10]);

			// 2. Searching
			Console.WriteLine("2. Searching");
			int searchingValue = 99;
			for (int i = 0; i < array.Length; i++)
			{
				if (searchingValue == array[i])
				{
					Console.WriteLine($"Value: {searchingValue} found in position: {i}");
					break;
				}
			}

			// 3. Insert at the beginning of the array
			Console.WriteLine("3. Insert at the beginning of the array");
			int position = 0;
			int newValue = -10;
			for (int i = size; i >= position ; i--)
			{
				array[i + 1] = array[i];
			}
			size++;
			array[position] = newValue;
			PrintArray(array, size);

			// 4. Insert at the very end of the array
			Console.WriteLine("4. Insert at the very end of the array");
			position = size;
			newValue = 110;
			array[position] = newValue;
			size++;
			PrintArray(array, size);

			// 5. Delete at the very beginning of the array
			Console.WriteLine("5. Delete at the very beginning of the array");
			int delPosition = 0;
			for (int i = delPosition; i <= size; i++)
			{
				array[i] = array[i + 1];
			}
			size--;
			PrintArray(array, size);

			// 6. Delete at the end of the array
			Console.WriteLine("6. Delete at the end of the array");
			delPosition = size;
			size--;
			PrintArray(array, size);
		}

		public static int[] FillArray(int fill, int size)
		{
			int[] tempArray = new int[size];
			for (int i = 0; i < fill; i++)
			{
				tempArray[i] = i + 1;
			}
			return tempArray;
		}
		public static void PrintArray(int[] arrayToPrint, int size)
		{
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine($"array[{i}] = {arrayToPrint[i]}");
			}
		}
	}

}
