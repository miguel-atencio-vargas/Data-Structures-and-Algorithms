using System;

namespace Exercise3	
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] numbers = { 10, 20, 50, 30, 40, 50 };
			int count = 0;
			foreach (var item in numbers)
			{
				if (50 == item)
				{
					count++;
				}
			}
			Console.WriteLine($"The number 50 appears: {count} times");
		}
	}
}