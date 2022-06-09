﻿/* 
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
5 -> 9
*/

double[,] getRandomArray(int rowNumber, int colNumber, int deviation)
{
    double[,] result = new double[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
    return result;
}
void print2DArray(double[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i + "]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
             Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[,] randomArray = getRandomArray(3, 4, 1);
print2DArray(randomArray);