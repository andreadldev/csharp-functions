using System;
int[] numeri = { 2, 6, 7, 5, 3, 9 };
Console.WriteLine("Array numeri:");
StampaArray(numeri);

int numeriSommati = sommaElementiArray(numeri);
Console.WriteLine($"\n\nSomma Array numeri: {numeriSommati}");

int[] numeriAlQuadrato = ElevaArrayAlQuadrato(numeri);
Console.WriteLine("\nArray numeri elevati al quadrato:");
StampaArray(numeriAlQuadrato);

//Funzioni
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

int sommaElementiArray(int[] array) 
{
	int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		sum += array[i];
	}
	return sum;
}

int Quadrato(int number)
{
	int square = number * number;
	return square;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
	int[] newArray = new int[array.Length];
	array.CopyTo( newArray, 0 );
	for (int i = 0; i < newArray.Length; i++)
	{
		newArray[i] = Quadrato(newArray[i]);
	}
	return newArray;
}