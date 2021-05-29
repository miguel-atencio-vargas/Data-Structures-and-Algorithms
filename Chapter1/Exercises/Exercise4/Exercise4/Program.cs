using System;

namespace Exercise4
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// we added a zero to the end to dont have probles with static arrays
			int[] numbers = { 72, 44, 66, 2019, 72, 55, 101, 72, 99, 2, 0 };
			int size = 10;
			int beforeSize = size;
			int steps = 0;
			while (true)
			{
				bool shiftData = false;
				for (int i = 0; i < size; i++)
				{
					if(72 == numbers[i])
					{
						shiftData = true;
					}
					if (shiftData)
					{
						numbers[i] = numbers[i + 1];
					}
					steps++;
				}
				if (shiftData)
				{
					size--;
				}
				if(beforeSize == size)
				{
					break;
				}
				beforeSize = size;
			}
			for (int i = 0; i < size; i++)
			{
				Console.Write(numbers[i] + " ");
			}
			Console.WriteLine("\nDelete all the 72's take: "+ steps + " steps");
		}
	}
}
