﻿/* Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result;
Console.Write($"{number} - > ");

for (int i = 1; i <= number; i++)
{
    result = i * i;
    Console.Write(result);
    if (i != number)
    {
        Console.Write(" , ");
    }
}