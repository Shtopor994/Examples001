/* 
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
5 -> 9
*/

Console.Write("Введите строку:");
int strg = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец:");
int clmn = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 3;
int m = 4; 
Random random = new Random();
int[,] array = new int[n, m];
Console.WriteLine("Исходный массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(10, 99);
        Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
}
if (strg < 0 | strg > array.GetLength(0) - 1 | clmn < 0 | clmn > array.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", array[strg, clmn]);
}
