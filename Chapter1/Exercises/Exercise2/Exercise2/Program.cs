using System;

namespace Exercise2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int size = 100;
			int[] set = FillSet(size, 150);

			// 1. Reading:
			Console.WriteLine("1. Reading");
			Console.WriteLine($"Position 10 have the value of: " + set[10]);

			// 2. Searching
			Console.WriteLine("2. Searching");
			int searchingValue = 99;
			for (int i = 0; i < set.Length; i++)
			{
				if (searchingValue == set[i])
				{
					Console.WriteLine($"Value: {searchingValue} found in position: {i}");
					break;
				}
			}

			// 3. Insert at the beginning of the set
			Console.WriteLine("3. Insert at the beginning of the set");
			int position = 0;
			int newValue = 10;
			bool allowInsert = VerifyDuplicity(set, size, newValue);
			if (allowInsert)
			{
				for (int i = size; i >= position; i--)
				{
					set[i + 1] = set[i];
				}
				size++;
				set[position] = newValue;
				PrintSet(set, size);
			}
			else
			{
				Console.WriteLine("Duplicated values is not allowed.");
			}

			// 4. Insert at the very end of the set
			Console.WriteLine("4. Insert at the very end of the set");
			position = size;
			newValue = 110;
			allowInsert = VerifyDuplicity(set, size, newValue);
			if (allowInsert)
			{
				set[position] = newValue;
				size++;
				PrintSet(set, size);
			}
			else
			{
				Console.WriteLine("Duplicated values is not allowed.");
			}

			// 5. Delete at the very beginning of the set
			Console.WriteLine("5. Delete at the very beginning of the set");
			int delPosition = 0;
			for (int i = delPosition; i <= size; i++)
			{
				set[i] = set[i + 1];
			}
			size--;
			PrintSet(set, size);

			// 6. Delete at the end of the set
			Console.WriteLine("6. Delete at the end of the set");
			delPosition = size;
			size--;
			PrintSet(set, size);
		}

		private static bool VerifyDuplicity(int[] set, int size, int value)
		{
			foreach (var item in set)
			{
				if (value == item) return false;
			}
			return true;
		}

		private static int[] FillSet(int fill, int size)
		{
			int[] tempSet = new int[size];
			for (int i = 0; i < fill; i++)
			{
				tempSet[i] = i + 1;
			}
			return tempSet;
		}
		private static void PrintSet(int[] setToPrint, int size)
		{
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine($"set[{i}] = {setToPrint[i]}");
			}
		}
	}
}
