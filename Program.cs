using System;
int[] numbers = { 2, 6, 7, 5, 3, 9 };
StampaArray(numbers);

void StampaArray(int[] array)
{
    Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}");
		if (i != array.Length - 1)
		{
			Console.Write(", ");
		}
	}
    Console.Write("]");
}