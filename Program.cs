using System;
int[] numeri = { 2, 6, 7, 5, 3, 9 };
Console.WriteLine("Lista numeri:");
StampaArray(numeri);

int[] numeriAlQuadrato = ElevaArrayAlQuadrato(numeri);
Console.WriteLine("\n\nLista numeri elevati al quadrato:");
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

int Quadrato(int number)
{
	int square = number * number;
	return square;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
	int[] newArray = array;
	for (int i = 0; i < newArray.Length; i++)
	{
		newArray[i] = Quadrato(newArray[i]);
	}
	return newArray;
}