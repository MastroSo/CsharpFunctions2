// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] Array1 = { 2, 6, 7, 5, 3, 9 };
StampaArray(Array1);
int[] Array2 = ElevaArrayAlQuadrato(Array1);
StampaArray(Array2);
//Dichiarazioni delle funzioni

void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}


int Quadrato(int numero)
{
    int quadrato = numero * numero;
    return quadrato;
}


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    for (int i = 0; i < array.Length; i++)
    {
        copiaArray[i] = Quadrato(copiaArray[i]);
    }
    return copiaArray;

}


int sommaElementiArray(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        somma = copiaArray[i];
    }
    return somma;
}