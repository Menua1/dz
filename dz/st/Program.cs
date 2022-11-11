/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/
int InputInt(string o)
{
    Console.Write(o);
    return int.Parse(Console.ReadLine());
}

void ArrRand (int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 5); 
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        
        Console.WriteLine();
    }
}

int size = InputInt("размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
ArrRand (matrixA);
ArrRand (matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = (matrixA[i, k] * matrixB[k, j]);
        }
    }
}

PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);
Console.WriteLine();
PrintArray(matrixC);