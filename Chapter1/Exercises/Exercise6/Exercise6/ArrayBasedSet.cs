using System;

class ArrayBasedSet
{
	private int[] set = new int[100];
	public int size;
	public ArrayBasedSet(int[] newArray)
	{
		size = newArray.Length;
		for (int i = 0; i < size; i++)
		{
			for (int j = i+1; j < size; j++)
			{
				if(newArray[i] == newArray[j])
				{
					Console.WriteLine("Duplicated values is not allowed on sets");
					set = new int[100];
					size = 0;
					return;
				}
			}
			set[i] = newArray[i];
		}
	}

	public void ReadSet()
	{
		for(int i=0; i<size; i++) Console.Write(set[i] + " ");
		Console.WriteLine();
	}

	public void Insert(int newValue, int position)
	{
		bool allowInsert = VerifyDuplicity(set, size, newValue);
		if (allowInsert)
		{
			for (int i = size; i >= position; i--) set[i + 1] = set[i];
			size++;
			set[position] = newValue;
		}
		else
		{
			Console.WriteLine($"{newValue} is already in the set.");
		}
	}

	public void Delete(int position)
	{
		for (int i = position; i <= size; i++)
		{
			set[i] = set[i + 1];
		}
		size--;
	}

	public int Search(int searchingValue)
	{
		for (int i = 0; i < set.Length; i++)
		{
			if (searchingValue == set[i]) return i;
		}
		return -1;
	}

	private static bool VerifyDuplicity(int[] set, int size, int value)
	{
		for(int i=0; i<size; i++)
		{
			if (set[i] == value) return false;
		}
		return true;
	}
}