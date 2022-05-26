/* 
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(100, 999);
    }
}

int[] array = new int[4];
FillArray(array);
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int j = 0; j < array.Length; j++)
    {
        if (j < array.Length - 1)
        {
            Console.Write($"{array[j]}, ");
        }
        else
        {
            Console.Write(array[j]);
            break;
        }
    }
    Console.Write("]");
}

int evenNumber(int[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Ваш массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Количество четных чисел в массиве: ");
int count = evenNumber(array);
Console.WriteLine($"{count}");

