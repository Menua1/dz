﻿/*
 Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
*/
// мучался ,в итоге списал все,ничего не понял.
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
     
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
     
        Console.WriteLine("");
    }
}