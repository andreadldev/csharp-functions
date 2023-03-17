using System;
int[] numeri = { 2, 6, 7, 5, 3, 9 };
Console.WriteLine("Array numeri:");
StampaArray(numeri);

int numeriSommati = sommaElementiArray(numeri);
Console.WriteLine($"\n\nSomma Array numeri: {numeriSommati}");

int[] numeriAlQuadrato = ElevaArrayAlQuadrato(numeri);
Console.WriteLine("\nArray numeri elevati al quadrato:");
StampaArray(numeriAlQuadrato);

//================================BONUS================================
Console.WriteLine("\n\n==================================");
Console.WriteLine("\nCREAZIONE ARRAY PERSONALIZZATO");

Console.WriteLine("Quanti elementi deve avere l'array? (Puoi inserire solo numeri da 1 a 10)");
int length = Convert.ToInt32(Console.ReadLine());

while (length < 1 || length > 10)
{
    Console.WriteLine("Input non valido. Il numero deve essere compreso tra 1 e 10");
    length = Convert.ToInt32(Console.ReadLine());
}

int[] customArray = new int[length];
for (int i = 0; i < customArray.Length; i++)
{
    Console.WriteLine("Scegli un numero da inserire nell'array");
	string insertNumber = Console.ReadLine();
    int aNumber;

	while (!Int32.TryParse(insertNumber, out aNumber))
	{
        Console.WriteLine("Input non valido, riprova");
        insertNumber = Console.ReadLine();
		continue;
    }
		int intValue;
		bool check = int.TryParse(insertNumber, out intValue);
		customArray[i] = intValue;
};

Console.WriteLine("Array con i numeri inseriti:");
StampaArray(customArray);

int numeriSommati2 = sommaElementiArray(customArray);
Console.WriteLine($"\n\nSomma Array numeri inseriti: {numeriSommati2}");

int[] numeriAlQuadrato2 = ElevaArrayAlQuadrato(customArray);
Console.WriteLine("\nArray numeri inseriti elevati al quadrato:");
StampaArray(numeriAlQuadrato2);

//=============================FUNZIONI===============================
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